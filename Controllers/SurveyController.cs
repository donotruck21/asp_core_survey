using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers
{
    public class SurveyController : Controller
    {
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            System.Console.WriteLine("ON INDEX");
            return View("Index");
        }


        [HttpPost]
        [Route("process")]
        public IActionResult Process(string name, string location, string language, string description)
        {
            System.Console.WriteLine(name);
            System.Console.WriteLine(location);
            System.Console.WriteLine(language);
            System.Console.WriteLine(description);

            ViewBag.name = name;
            ViewBag.location = location;
            ViewBag.language = language;
            ViewBag.description = description;
            return View("Success");
        }
    }
}