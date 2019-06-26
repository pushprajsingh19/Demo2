using DnbLivUrlShortUI.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace DnbLivUrlShortUI.Controllers
{
    public class UrlShortController : Controller
    {
        private readonly string _ApiUrl = ConfigurationManager.AppSettings["ApiUrl"];
        [HttpGet]
        public ActionResult Index()
        {

            UrlModell url = new UrlModell();
            return View(url);
        }

        [HttpPost]
        public ActionResult Index(UrlModell url)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {

                    client.BaseAddress = new Uri(_ApiUrl);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


                    string result = client.PostAsync("/short",
                                                  url.LongURL,
                                                  new JsonMediaTypeFormatter())
                                        .Result
                                        .Content
                                        .ReadAsAsync<string>()
                                        .Result;


                    url.ShortURL = result;
                    //ViewData["ShortURL"] = result;
                    return View(url);

                }
                //return View();
            }
            return View();
        }
    }
}