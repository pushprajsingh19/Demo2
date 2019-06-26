using DnbLife.Vips.BussinessLayer;
using DnbLiv.Vips.UrlShort.Filter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.OutputCache.V2;

namespace DnbLiv.Vips.UrlShort.Controllers
{
    public class UrlShortController : ApiController
    {
        private readonly IShortUrlManager _IshortUrlManager;
        public UrlShortController(IShortUrlManager IshortUrlManager)
        {
            _IshortUrlManager = IshortUrlManager;
        }

        [HttpGet]
        [Route("{key}")]
        [CacheFilter(TimeDuration = 20)]
        //[CacheOutput(ServerTimeSpan = 10)]
        public HttpResponseMessage Get(string key)
        {

            var response = Request.CreateResponse(HttpStatusCode.Moved);
            String urlString = _IshortUrlManager.GetUrl(key);
            if (!String.IsNullOrWhiteSpace(urlString))
            {
                response.Headers.Location = new Uri(urlString);
                return response;
            }
            return null;
        }

        [HttpPost]
        [Route("short")]
        [CacheFilter(TimeDuration = 10)]
        public HttpResponseMessage Craete([FromBody] String url)
        {
            return Request.CreateResponse(HttpStatusCode.OK, new Uri(VipsConfigManager.ApiUrl + _IshortUrlManager.AddShortUrl(url)));          

        }
    }
}
