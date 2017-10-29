using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HTML_Fundamentals.Controllers
{
    public class LessonsController : Controller
    {
        public IActionResult Index()
        {
            return View();

            //// einstiegspunkt, umleiten auf aktuelle View
            //var highestMethodsPerNumerInName = this.GetType().GetMethods()
            //    .Where(a => a.Name.StartsWith("Lesson"))
            //    .Aggregate((a, b) => GetNumerOfName(a) > GetNumerOfName(b) ? a : b);

            //return highestMethodsPerNumerInName.Invoke(this, null) as IActionResult;

            //int GetNumerOfName(MethodInfo mi) => Convert.ToInt32(new string(mi.Name.Where(b => char.IsNumber(b)).ToArray()));
        }

        public IActionResult Lesson02()
        {
            return View(nameof(Lesson02));
        }

        public IActionResult Lesson05()
        {
            return View(nameof(Lesson05));
        }

        public IActionResult Lesson08()
        {
            return View(nameof(Lesson08));
        }

        public IActionResult Lesson09()
        {
            return View(nameof(Lesson09));
        }

        public IActionResult Lesson10()
        {
            return View(nameof(Lesson10));
        }

        public IActionResult SubmitLesson10()
        {
            return View(nameof(Lesson10));
        }

        public IActionResult Lesson11()
        {
            return View(nameof(Lesson11));
        }

        public IActionResult Lesson12()
        {
            return View(nameof(Lesson12));
        }

        public IActionResult Lesson13()
        {
            return View(nameof(Lesson13));
        }

        public IActionResult Lesson14()
        {
            return View(nameof(Lesson14));
        }

        public IActionResult Lesson15()
        {
            return View(nameof(Lesson15));
        }

        public IActionResult Lesson16()
        {
            return View(nameof(Lesson16));
        }

        public IActionResult Lesson17()
        {
            return View(nameof(Lesson17));
        }

        public IActionResult Lesson18()
        {
            return View(nameof(Lesson18));
        }

        public IActionResult Lesson19()
        {
            return View(nameof(Lesson19));
        }
    }
}