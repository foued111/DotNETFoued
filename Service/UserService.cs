using Data;
using Data.Infrastructure;
using Domain;
using Newtonsoft.Json;
using Services.Pattern;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Service
{
 public   class UserService : Service<user> , IUserService
    {
        private static DatabaseFactory Dbf = new DatabaseFactory();
    private static UnitOfWork utw = new UnitOfWork(Dbf);
    public UserService() : base(utw)
        {
    }
        /**************** Consomation du web service pour l'ajout d'un volunteer ********************/
        public void addRec(string firstName,String lastName,String phoneNum , String password,String login,String email)
        {
            DateTime dateParsed = DateTime.Now;
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
                ("http://localhost:18080/volunteering-web/v0/test");
            request.Method = "Post";
            request.ContentType = "application/json";
            using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(@"{
                        ""firstName"": """ + firstName + @""",
  ""lastName"": """ + lastName + @""",
  ""phoneNum"": """ + phoneNum + @""",
  ""password"": """ + password + @""",
  ""login"": """ + login + @""",
  ""email"": """ + email + @"""
                        }}");
                sw.Close();
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            using (StreamReader r = new StreamReader(responseStream))
                            {

                            }
                        }
                    }

                }
            }
        }





        /**************** Consomation du web service pour afficher les volunteers ********************/

        public IEnumerable<user> afficher()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/volunteering-web/v0/test");
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = string.Empty;
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }
            var objs = JsonConvert.DeserializeObject<List<user>>(content);
            List<user> liste = new List<user>();
            foreach (user r in objs)
            {
                user rec = new user(r.id,r.firstName, r.lastName, r.phoneNum, r.password, r.login, r.email);

                liste.Add(rec);
            }
            return liste;
        }




        /********************** Consommation du delete *************************/
        public void deleteRec(int? id)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/volunteering-web/v0/test/" + id);
            request.Method = "DELETE";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }

       

         



    }
}
