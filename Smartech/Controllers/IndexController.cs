using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Smartech.Pages;
using System.Net;

namespace Smartech.Controllers
{
    public class IndexController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, string lang)
        {
            Console.WriteLine(lang);
            return View(new WelcomeModel(name));
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            return RedirectPermanent("/Index/Welcome?name=" + WebUtility.UrlEncode(name) + "&lang=" + "ru");
        }
    }
}
