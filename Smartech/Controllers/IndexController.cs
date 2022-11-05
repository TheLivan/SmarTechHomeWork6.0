using Microsoft.AspNetCore.Mvc;
using Smartech.Data;
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
            using var db = new SampleContext();
            var langMessage = db.Languages.OrderBy(b => b.Lang.Equals(lang)).Last();
            return View(new WelcomeModel(name, langMessage.Message));
        }

        [HttpPost]
        public IActionResult Index(string name)
        {
            return RedirectPermanent("/Index/Welcome?name=" + WebUtility.UrlEncode(name) + "&lang=" + "ru");
        }
    }
}
