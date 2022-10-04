using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Analytics.Models;
using System.Net;

namespace Show_Result.Controllers
{
    public class Analytics1Controller : Controller
    {
        private readonly AnalyticsDbContext _context;

        public Analytics1Controller(AnalyticsDbContext context)
        {
            _context = context;
        }

        

         
        public async Task<IActionResult> Details(int? id)
        {

            var responseString = "";
            var request = HttpWebRequest.CreateHttp("http://host.docker.internal:49400/api/Analytics/Claculate");
            request.Method = "GET";
            request.ContentType = "application/json";
 

            using  (var response1 =  await request.GetResponseAsync())
            {
                using (var reader =  new StreamReader(response1.GetResponseStream()))
                {
                    
                    responseString = reader.ReadToEnd();
                }
            }
            


            var analytics = await _context.Analytics
                .FirstOrDefaultAsync(m => m.id == id);
             
            return View(analytics);
        }


         
    }
}
