using Enter_Data_BackEnd.Models;
using Microsoft.AspNetCore.Mvc;

namespace Enter_Data_BackEnd.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
         

        private readonly NumbersDbContext _context;
        public NumbersController(NumbersDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> addData(Numbers numbers)
        {
            try
            {
                var oldNum = _context.Numbers.Find(1);
                if (oldNum == null)
                {
                    _context.Numbers.Add(numbers);
                    _context.SaveChanges();
                    return Ok();

                }
                oldNum.Number1 = numbers.Number1;
                oldNum.Number2 = numbers.Number2;
                oldNum.Number3 = numbers.Number3;
                oldNum.Number4 = numbers.Number4;
                oldNum.Number5 = numbers.Number5;

                _context.Numbers.Update(oldNum);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception)
            {

                throw;
            }

        }

    }
}
