using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Haushaltsbuch.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IncomeController : Controller
    {
        [HttpGet]
        public ActionResult Get()
        {
            return RedirectToAction(nameof(Index));
        }
        //ToDo: Define Route for this
        //[HttpPost]
        //public ActionResult Create()
        //{
        //        return RedirectToAction(nameof(Index));
        //}

        [HttpPost]
        public ActionResult Edit()
        {
                return RedirectToAction(nameof(Index));
        }

        [HttpDelete]
        public ActionResult Delete()
        {
                return RedirectToAction(nameof(Index));
        }
    }
}
