using Fina.AvaliacaoTecnica.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fina.Controllers
{
    public class HomeController : Controller
    {
        private readonly IServiceBusiness _serviceBusiness;
        public HomeController(IServiceBusiness serviceBusiness)
        {
            _serviceBusiness = serviceBusiness;
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}