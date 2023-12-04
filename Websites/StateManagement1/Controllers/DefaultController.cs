using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace StateManagement1.Controllers
{
    public class DefaultController : Controller
    {
        // GET: DefaultController
        public ActionResult Index()
        {
            ViewData["a"] = 100;
            TempData["b"] = 200;
            //return View();

            return RedirectToAction("Index2");
        }

        public ActionResult Index2()
        {
            return View();
        }
         
        public ActionResult Session1()
        {

            HttpContext.Session.SetInt32("a", 10);
            HttpContext.Session.SetString("b", "abcd");
           

            Employee emp = new Employee { EmpNo = 1, Name = "Rushikesh" };
            string jsonEmp=JsonSerializer.Serialize<Employee>(emp);
            HttpContext.Session.SetString("emp",jsonEmp);

            //HttpContext.Session.SetString("emp",JsonSerializer.Serialize<Employee>(emp));

            //return RedirectToAction("Session2");
            return View();
        }
        public ActionResult Session2()
        {
            int a= HttpContext.Session.GetInt32("a").Value;
            string b = HttpContext.Session.GetString("b");

            string e = HttpContext.Session.GetString("emp");
            Employee emp = JsonSerializer.Deserialize<Employee>(e);

            ViewBag.name = emp.Name;



            return View();
        }
        public ActionResult Session3()
        {
            return View();
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }

    }

}
