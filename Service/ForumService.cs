using Data;
using Data.Infrastructure;
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
    public class ForumService : Service<forum>, IForumService
    {
        private static DatabaseFactory Dbf = new DatabaseFactory();
        private static UnitOfWork utw = new UnitOfWork(Dbf);
        public ForumService() : base(utw)
        {
        }

        public void createPost(forum f)
        {
            //DateTime dateParsed = DateTime.Now;
            //f.date = DateTime.Now;
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
                ("http://localhost:18080/volunteering-web/volunteering-rs/forum");
            request.Method = "Post";
            request.ContentType = "application/json";
            using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(@"{
                        ""subject"": """ + f.subject + @""",
                        ""description"": """ + f.description + @""",
                        ""question"": """ + f.question + @"""
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

        public void updatePost(forum f)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
                ("http://localhost:18080/volunteering-web/volunteering-rs/forum/?forum_id="+f.id);
            request.Method = "Put";
            request.ContentType = "application/json";
            using (StreamWriter sw = new StreamWriter(request.GetRequestStream()))
            {
                sw.Write(@"{
                        ""subject"": """ + f.subject + @""",
                        ""description"": """ + f.description + @""",
                        ""question"": """ + f.question + @"""
                        }");
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

        public void deletePost(int? id)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/volunteering-web/volunteering-rs/forum/deleteforum/?fdelete_id=" + id);
            request.Method = "DELETE";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        }

        public IEnumerable<forum> readForum()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/volunteering-web/volunteering-rs/forum");
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
            var objs = JsonConvert.DeserializeObject<List<forum>>(content);
            List<forum> liste = new List<forum>();
            foreach (forum post in objs)
            {
                //reclamation rec = new reclamation(r.id, r.content, (DateTime)r.date, r.etat, r.title, r.type);
                forum f = new forum(post.id, post.subject, post.question, post.description, post.date);
                liste.Add(f);
            }
            return liste;
        }

        public IEnumerable<forum> readForumByIdUser()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/volunteering-web/volunteering-rs/forum/myforum/?myf_id=" + 1);
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
            var objs = JsonConvert.DeserializeObject<List<forum>>(content);
            List<forum> liste = new List<forum>();
            foreach (forum post in objs)
            {
                //reclamation rec = new reclamation(r.id, r.content, (DateTime)r.date, r.etat, r.title, r.type);
                forum f = new forum(post.id, post.subject, post.question, post.description, post.date);
                liste.Add(f);
            }
            return liste;
        }

        public forum readForumById(int id)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/volunteering-web/volunteering-rs/forum/" + id);
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
            forum myf = JsonConvert.DeserializeObject<forum>(content);
            return myf;
        }

    }
}
