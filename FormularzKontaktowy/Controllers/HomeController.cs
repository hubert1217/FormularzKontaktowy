using FormularzKontaktowy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormularzKontaktowy.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczór";
            return View();
        }

        [HttpGet]
        public ViewResult ContactForm()
        {
            return View();
        }
        
        [HttpPost]
        public ViewResult ContactForm(Client client) 
        {
            return View("Thanks", client);
        }



    }
}