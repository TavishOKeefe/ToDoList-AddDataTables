using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();

            // this return below is for intentionally failing the test
            // uncomment it, and comment the return View(); above to make
            // that test fail
            // return new EmptyResult();
        }
    }
}
