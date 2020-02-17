using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RockolaConService.Models;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace RockolaConService.Controllers
{
    public class HistorialController : Controller
    {
        string baseUrl = "http://localhost:7010/";
        // GET: Historial
        public async Task <ActionResult> Index()
        {
            List<Video> videoinfo = new List<Video>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //videos del http client
                HttpResponseMessage res = await client.GetAsync("api/historialt/");
                if (res.IsSuccessStatusCode)
                {
                    var videoResponse = res.Content.ReadAsStringAsync().Result;
                    videoinfo = JsonConvert.DeserializeObject<List<Video>>(videoResponse);
                }
            }
                return View(videoinfo);
        }

        [HttpPost]
        public ActionResult PostToHistorial (Video video)
        {
            using (var cliente = new HttpClient())
            {
                cliente.BaseAddress = new Uri("http://localhost:7010/");
                video = new Video()
                {
                    videoName = "debanhi prueba",
                    videoId = "debanhi prueba"
                };
                var postJob = cliente.PostAsJsonAsync<Video>("api/historialt/", video);
                postJob.Wait();
                var postResult = postJob.Result;
                if (postResult.IsSuccessStatusCode)
                    return RedirectToAction("Index");


            }
            ModelState.AddModelError(string.Empty, "server error");
            return View(video);
        }
    }
}