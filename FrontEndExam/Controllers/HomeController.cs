using FrontEndExam.DAL;
using FrontEndExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FrontEndExam.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext db = new MovieContext();

        // GET: Movies
        public ActionResult Index()
        {
            return View(db.Movies.ToList());
        }
   
        /*
        public ActionResult Index()
        {
            return View();
        }
        */
        public ActionResult About()
        {
            return View(db.Movies.ToList());
        }


        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}