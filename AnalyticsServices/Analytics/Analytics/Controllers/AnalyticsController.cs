using Analytics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Analytics.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {
        private readonly NumbersDbContext _context;
        private readonly AnalyticsDbContext _context2;

        public AnalyticsController(NumbersDbContext context, AnalyticsDbContext context2)
        {
            _context = context;
            _context2 = context2;
        }

        [HttpGet]
        public async Task<IActionResult> Claculate()
        {
            try
            {
               var numbers= _context.Numbers.Find(1);
                
                List<int> listNumbers = new List<int>();
                 listNumbers.Add(numbers.Number1);
                 listNumbers.Add(numbers.Number2);
                 listNumbers.Add(numbers.Number3);
                 listNumbers.Add(numbers.Number4);
                 listNumbers.Add(numbers.Number5);


                var statics = _context2.Analytics.Find(1);
                if (statics == null)
                {
                    var newStatics = new Models.Analytics
                    {
                        max = listNumbers.Max(),
                        min = listNumbers.Min(),
                        sum = listNumbers.Sum(),
                        avg = (int)listNumbers.Average()

                    };
                    _context2.Analytics.Add(newStatics);
                    _context2.SaveChanges();
                    return Ok();

                }

                statics.max = listNumbers.Max();
                statics.min = listNumbers.Min();
                statics.sum = listNumbers.Sum();
                statics.avg = (int)listNumbers.Average();

                    
                
               
                _context2.Analytics.Update(statics);
                _context2.SaveChanges();


                return Ok();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
