using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace GetApi.Controllers
{
    public class GetApiController : Controller
    {
        // GET: GetApi
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/posts");
            return View();
        }
    }
}