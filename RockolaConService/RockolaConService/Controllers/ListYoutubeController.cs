using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RockolaConService.Controllers
{
    public class ListYoutubeController : Controller
    {
        string baseUrl = "http://localhost:7020/";



        //public ActionResult SearchList(string keyword)
        //{
        //    ServiceReference1.Service1Client cliente = new ServiceReference1.Service1Client();
        //    //ViewBag.cliente = new ServiceReference1.Service1Client();

        //    ViewBag.lista = cliente.GetListYoutube(keyword).ToList();
        //    //return View(cliente.GetListYoutube(keyword).ToList());
        //    return View();

        //}

        //public async Task<ActionResult> searchList(string keyword)
        //{
        //    var videos = new List<string>();
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri(baseUrl);
        //        client.DefaultRequestHeaders.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        //        keyword = "bandas";
        //        HttpResponseMessage res = await client.GetAsync("api/listyoutube/" + keyword);
                
        //        if (res.IsSuccessStatusCode)
        //        {
        //            var listResponse = res.Content.ReadAsStringAsync().Result;
        //            var info = JsonConvert.DeserializeObject<List<string>>(listResponse);
        //            return View(info);
        //        }
                
        //        //var info = JsonConvert.DeserializeObject<List<Video>>(respuesta);
        //    }
        //    return View();
        //}
   
        // GET: ListYoutube
        public ActionResult Index()
        {
            return View();
        }
    }
}