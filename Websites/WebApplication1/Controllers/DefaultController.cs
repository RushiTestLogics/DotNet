using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index(int? id,int a=10,int b=20,int c=30)
        {
            //if(id == null)
            //    return NotFound();

            ViewBag.id = id;
            ViewBag.a = a;
            ViewBag.b = b;
            ViewBag.c = c;

            return View();
        }

        public IActionResult View1()
        {
            return View("Index1");
        }

        public IActionResult View2()
        {
            return View("Index2");
        }

        public IActionResult View3()
        {
            return View("Index3");
        }

        public IActionResult View4()
        {
            return View("Index4");
        }

        public IActionResult View5()
        {
            return View();
        }
    }
}
