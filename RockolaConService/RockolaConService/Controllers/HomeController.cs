using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RockolaConService.ServiceReference1;

namespace RockolaConService.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {

            return View();
        }

        //FUNCIONA PARA EL SERVICIO DE WCF

        //public ActionResult SearchList(string keyword)
        //{
        //    ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
        //    //ViewBag.cliente = new ServiceReference1.Service1Client();

        //    ViewBag.lista = cliente.GetListYoutube(keyword).ToList();
        //    //return View(cliente.GetListYoutube(keyword).ToList());
        //    return View();

        //}
    


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