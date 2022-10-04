using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Show_Result.Models;
using System.Diagnostics;
using System.Net;
using System.Text.Json;

namespace Show_Result.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Login([Bind("Email,Password")] Login login)
        {

            var responseString = "";
            var request = (HttpWebRequest)WebRequest.Create("http://host.docker.internal:49100/Auth.json");
            request.Method = "GET";
            request.ContentType = "application/json";

            using (var response1 = request.GetResponse())
            {
                using (var reader = new StreamReader(response1.GetResponseStream()))
                {
                    responseString = reader.ReadToEnd();
                }
            }
            
            var jsonParsing = JObject.Parse(responseString);


            if (login.Email == jsonParsing["Email"].ToString()
                && login.Password== jsonParsing["Password"].ToString())
             return RedirectToAction("Details", "Analytics1", new { id = 1 });
            return RedirectToAction("Index", "Home");

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}