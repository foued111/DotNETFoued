using Data;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace VolunteeringGUI.Controllers.Forum
{
    public class ForumController : Controller
    {
        ForumService forumS = new ForumService();
        // GET: Forum
        public ActionResult Index()
        {
            IEnumerable<forum> liste = forumS.readForum();
            return View(liste);
        }

        public ActionResult MyForumDetails(int id, string submit, FormCollection collection)
        {
            forum f = forumS.readForumById(id);
            if(submit == "Update Post!")
            { 
                    try
                    {
                        //forum f = null;
                        //// TODO: Add update logic here
                        //f = forumS.readForumById(id);

                        f.subject = collection["subject"];
                        f.question = collection["question"];
                        f.description = collection["description"];

                        if (ModelState.IsValid)
                        {
                            forumS.updatePost(f);
                            return RedirectToAction("MyForum");
                        }
                        return View("MyForumDetails", f);
                    }
                    catch
                    {
                        return View();
                    }
            }
            return View(f);
        }

        public ActionResult MyForum()
        {
            IEnumerable<forum> liste = forumS.readForumByIdUser();
            return View(liste);
        }

        // GET: Forum/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Forum/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Forum/Create
        [HttpPost]
        public ActionResult Create(forum f, FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                f.subject = collection["subject"];
                f.question = collection["question"];
                f.description = collection["description"];
                
                if (ModelState.IsValid)
                {
                    forumS.createPost(f);
                    return RedirectToAction("Index");
                }
                return View("Create", f);
            }
            catch
            {
                return View();
            }
        }

        // GET: Forum/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Forum/Edit/5
        [HttpPost]
        public ActionResult Edit(forum f, FormCollection collection)
        {
            try
            {
                //forum f = null;
                //// TODO: Add update logic here
                //f = forumS.readForumById(id);

                f.subject = collection["subject"];
                f.question = collection["question"];
                f.description = collection["description"];

                if (ModelState.IsValid)
                {
                    forumS.updatePost(f);
                    return RedirectToAction("MyForum");
                }
                return View("Edit", f);
            }
            catch
            {
                return View();
            }
        }

        // GET: Forum/Delete/5
        public ActionResult Delete(int? id)
        {
            try
            {
                forumS.deletePost(id);
                return RedirectToAction("MyForum");
            }
            catch
            {
                return View();
            }
        }

        // POST: Forum/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
