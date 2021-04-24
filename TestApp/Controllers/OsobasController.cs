using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestApp.Models;
using TestApp.ViewModels;

namespace TestApp.Controllers
{
    public class OsobasController : Controller
    {
        // GET: Osobas
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult New()
        {
            var viewModel = new OsobaViewModel();

            

            return View(viewModel);
        }

        public ActionResult Save(OsobaViewModel o)
        {
            string a = o.Risk.ToString();

            return RedirectToAction("Index", "Osobas");
        }
    }
}