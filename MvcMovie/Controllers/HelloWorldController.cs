using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome(string name, int id = 1)
        {
            ViewData["Message"] = "Hello your name is " + name + "  Right!";
            ViewData["NumTimes"] = id;
            return View();
        }


        /*public string Index()
        {
            return "This is my default action...";
        }
        // 
        // GET: /HelloWorld/Welcome/ 
        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
        */


        /* public string Welcome(string name, int numTimes = 1)
         {
             return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
         }*/
        
    }
}