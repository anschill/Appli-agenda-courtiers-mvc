using Agenda.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Agenda.Controllers
{
    public class HomeController : Controller
    {
        //Création d'une variable privée de type DbContext qui est un objet, on instancie la class dbContext
        private AgendaContext db = new AgendaContext();

        public ActionResult Index()
        {
            ViewData["date"] = DateTime.Now;
            return View();
        }

        public ActionResult AddBroker()
        {
            return View();
        }
        public ActionResult AddCustomer()
        {   return View();
        }
        public ActionResult AddAppointment()
        {  
            return View();
        }
        public ActionResult ListBrokers()
        {
            List<Broker> brokers = db.Brokers.ToList();
            // retourne la liste Brokers dans la View ListBrokers
            return View(brokers);
        }
        public ActionResult ListCustomers()
        {
            return View();
        }
        public ActionResult ProfilBrokers()
        {
            return View();
        }
    }
}