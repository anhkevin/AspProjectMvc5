using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DemoValidation.Models;

namespace FormValidation.Controllers
{
    public class ValidationController : Controller
    {
        // GET: Validation
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "name, pass")] ValidationModels ModelsValidation)
        {
            if (ModelState.IsValid)
            {
                // Code
                /*
                db.Movies.Add(movie);
                db.SaveChanges();
                */
                var name = Request.QueryString["name"];


                return RedirectToAction("Index");
            }
            return View(ModelsValidation);
        }
    }
}