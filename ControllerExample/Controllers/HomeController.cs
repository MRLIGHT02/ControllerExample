using Microsoft.AspNetCore.Mvc;
using ControllerExample.Models;
using System.Runtime.CompilerServices;

namespace ControllerExample.Controllers
{

    public class HomeController : Controller
    {
        [Route("hello")]
        [Route("/")]
        public JsonResult Index()
        {
            //return new ContentResult() { Content = "Hello From Content Type Result", ContentType = "text/plain" };
            Person person = new() { Id = Guid.NewGuid(), FirstName = "shalu", LastName = "singla",Age=40 };
            //return Content("  <style>\r\n    body {\r\n      background-color: #000;\r\n      color: #33ff33;\r\n      font-family: 'Courier New', Courier, monospace;\r\n      padding: 20px;\r\n    }\r\n\r\n    .terminal {\r\n      max-width: 800px;\r\n      margin: 40px auto;\r\n      border: 2px solid #33ff33;\r\n      padding: 20px;\r\n      border-radius: 10px;\r\n      box-shadow: 0 0 20px #33ff33;\r\n    }\r\n\r\n    h1::after {\r\n      content: \"|\";\r\n      animation: blink 0.8s infinite;\r\n    }\r\n\r\n    h1 {\r\n      font-size: 28px;\r\n      white-space: nowrap;\r\n      overflow: hidden;\r\n      width: 100%;\r\n      animation: typewriter 3s steps(30) 1;\r\n    }\r\n\r\n    @keyframes blink {\r\n      0%, 100% { opacity: 1; }\r\n      50% { opacity: 0; }\r\n    }\r\n\r\n    @keyframes typewriter {\r\n      from { width: 0; }\r\n      to { width: 100%; }\r\n    }\r\n\r\n    .section {\r\n      margin-top: 20px;\r\n    }\r\n\r\n    .section h2 {\r\n      border-bottom: 1px dashed #33ff33;\r\n      padding-bottom: 5px;\r\n      margin-bottom: 10px;\r\n    }\r\n\r\n    a {\r\n      color: #00ffff;\r\n      text-decoration: none;\r\n    }\r\n\r\n    a:hover {\r\n      text-decoration: underline;\r\n    }\r\n  </style>\r\n</head>\r\n<body>\r\n  <div class=\"terminal\">\r\n    <h1>Hi, I'm Saif aka Code Zero</h1>\r\n\r\n    <div class=\"section\">\r\n      <h2>About Me</h2>\r\n      <p>I’m a passionate BCA student and self-taught developer aiming to become a world-class engineer and launch my own startup by 2028.</p>\r\n    </div>\r\n\r\n    <div class=\"section\">\r\n      <h2>Skills</h2>\r\n      <ul>\r\n        <li>C#, .NET MAUI, ASP.NET Core</li>\r\n        <li>HTML, CSS, JavaScript</li>\r\n        <li>SQL Server, Git, REST APIs</li>\r\n      </ul>\r\n    </div>\r\n\r\n    <div class=\"section\">\r\n      <h2>Projects</h2>\r\n      <ul>\r\n        <li>PerfectPay - A bill splitting mobile app built using .NET MAUI</li>\r\n        <li>Weather Terminal - Console-style weather app using API</li>\r\n      </ul>\r\n    </div>\r\n\r\n    <div class=\"section\">\r\n      <h2>Contact</h2>\r\n      <p>Email: saif@example.com</p>\r\n      <p>GitHub: <a href=\"https://github.com/saif\">github.com/saif</a></p>\r\n    </div>\r\n  </div>\r\n</body>", "text/html");
            return new JsonResult(person);
        }
        [Route(@"contact/num/{number:regex(^\d{{10}}$)}")]
        public string Contact()
        {
            return "hello from contact ";
        }
        [Route("download")]
        public string? Download()
        {
            return "";
        }

    }

}
