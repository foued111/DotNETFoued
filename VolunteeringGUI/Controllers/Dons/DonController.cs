using Data;
using Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolunteeringGUI.Controllers.Dons
{
    public class DonController : Controller
    {
        private DonService ds = new DonService();
        // GET: Don
        public ActionResult Index()
        {
            return View(ds.GetAll());
        }

        // GET: Don/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Don/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Don/Create
        [HttpPost]
        public ActionResult Create(Don don , HttpPostedFileBase Imag)
        {
            String imagName = "";
            int x = Imag.FileName.LastIndexOf("\\");
            imagName = Imag.FileName.Substring(x + 1);
            don.picture = imagName;
            Imag.SaveAs(Path.Combine(Server.MapPath("~/Content/"), imagName));
            don.id = 145;
            ds.Add(don);
            ds.Commit();
            return RedirectToAction("Index");
        }

        // GET: Don/Edit/5
        public ActionResult Edit(int id)
        {
            return View(ds.Get(e => e.DonId == id));
        }

        // POST: Don/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Don don)
        {
            Don d1 = ds.Get(e => e.DonId == id);
            d1.dateDon = don.dateDon;
            d1.Name = don.Name;
            d1.Type = don.Type;
            ds.Update(d1);
            ds.Commit();
            return RedirectToAction("Index");
        }

        // GET: Don/Delete/5
        public ActionResult Delete(int id)
        {
            return View(ds.Get(e => e.DonId == id));
        }

        // POST: Don/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Don don)
        {
            ds.Delete(ds.Get(e => e.DonId == id));
            ds.Commit();
            return RedirectToAction("Index");
        }
        public ActionResult Dashbord()
        {
            var list = ds.GetAll();
            List<int> repartitions = new List<int>();
            var donations = list.Select(x => x.id).Distinct();
            foreach (var item in donations)
            {
                repartitions.Add(list.Count(x => x.id == item)); 
            }
            var rep = donations;
            ViewBag.DONATIONS = donations;
            ViewBag.REP = donations.ToList();


            return View();
        }
    }
}
