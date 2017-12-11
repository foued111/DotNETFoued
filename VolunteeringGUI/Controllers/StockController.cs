using Domain;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolunteeringGUI.Controllers
{
    public class StockController : Controller
    {
        stockService ss = new stockService();

        // GET: Stock
        public ActionResult Index()
        {
            return View(ss.GetAll());
        }

        // GET: Stock/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Stock/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stock/Create
        [HttpPost]
        public ActionResult Create(stock s)
        {
                ss.Add(s);
                ss.Commit(); 

                return RedirectToAction("Index");
         
        }

        // GET: Stock/Edit/5
        public ActionResult Edit(int id)
        {
            stock st = ss.GetById(id);
            return View(st);
        }

        // POST: Stock/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, stock don)
        {

            stock d1 = ss.Get(e => e.Id == id);
            d1.description = don.description;
            d1.type = don.type;
      
            ss.Update(d1);
            ss.Commit();
            return RedirectToAction("Index");
        }

        // GET: Stock/Delete/5
        public ActionResult Delete(int id)
        {
            stock st = ss.GetById(id);
            return View(st);
        }

        // POST: Stock/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, stock st)
        {
            try
            {
                stock s1 = new stock();
                s1 = ss.GetById(id);
                ss.Delete(s1);
                ss.Commit();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
