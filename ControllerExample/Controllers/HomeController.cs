using Microsoft.AspNetCore.Mvc;

namespace ControllerExample.Controllers
{
    public class HomeController
    {
        [Route("hello")]
        public string Method1()
        {
            return "Hello From Controller";
        }
        [Route(@"contact/num/{number:regex(^\d{{10}}$)}")]
        public string Contact()
        {
            return "hello from contact ";
        }

    }

}
