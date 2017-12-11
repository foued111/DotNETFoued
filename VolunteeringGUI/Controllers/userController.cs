using Data;
using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolunteeringGUI.Controllers
{
    public class userController : Controller
    {
        UserService ss = new UserService();
        




        // GET: User
        public ActionResult Index()
        {
            IEnumerable<user> liste = ss.afficher();
            return View(liste);

        }

        // GET: User/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Stock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        public ActionResult Create(user s, FormCollection formvalues)
        {

            try
            {
                //r.date = DateTime.Now;
               
                s.firstName = formvalues["firstName"];
                s.lastName = formvalues["lastName"];
                s.phoneNum = formvalues["phoneNum"];
                s.password = formvalues["password"];
                s.login = formvalues["login"];
                s.email = formvalues["email"];


                //  r.Id_Offer = (int?)formvalues["Id_Offer"];
                ss.addRec(s.firstName, s.lastName, s.phoneNum, s.password,s.login,s.email);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }

        // GET: User/Edit/5
        public ActionResult Edit(int id)
        {
            user st = ss.GetById(id);
            return View(st);
        }

        // POST: User/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, user don)
        {
            user d1 = ss.Get(e => e.id == id);
            d1.firstName = don.firstName;
            d1.lastName = don.lastName;
            d1.login = don.login;
            d1.password = don.password;
            d1.phoneNum = don.phoneNum;
            d1.email = don.email;

            ss.Update(d1);
            ss.Commit();
            return RedirectToAction("Index");
        }

        // GET: User/Delete/5
        public ActionResult Delete(int id)
        {
            user st = ss.GetById(id);
            return View(st);
        }

        // POST: User/Delete/5
        [HttpPost]
        public ActionResult Delete(int? id)
        {
            try
            {
                ss.deleteRec(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
