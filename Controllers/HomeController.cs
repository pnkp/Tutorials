using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ViewsProject.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Controller = nameof(HomeController);
            ViewBag.Action = nameof(Index);
            return View("Views/Test/Test.cshtml");
        }

        public ViewResult Action()
        {
            var dict = new Dictionary<string, string>
            {
                ["Controller"] = nameof(HomeController),
                ["Action"] = nameof(Action)
            };
            return View(dict);
        }

        public ViewResult List()
        {
            ViewBag.Controller = nameof(HomeController);
            ViewBag.Action = nameof(List);
            return View("Index");
        }

        public ViewResult Shared()
        {
            ViewBag.Controller = nameof(HomeController);
            ViewBag.Action = nameof(List);
            return View("SharedView");
        }
    }
}