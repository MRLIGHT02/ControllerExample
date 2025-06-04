using Microsoft.AspNetCore.Mvc;

namespace ControllerExample.Controllers
{

    public class HomeController : Controller
    {
        [Route("hello")]
        [Route("/")]
        public ContentResult Index()
        {
            //return new ContentResult() { Content = "Hello From Content Type Result", ContentType = "text/plain" };
            return Content("Hello From Controller", "text/plain");
        }
        [Route(@"contact/num/{number:regex(^\d{{10}}$)}")]
        public string Contact()
        {
            return "hello from contact ";
        }

    }

}
