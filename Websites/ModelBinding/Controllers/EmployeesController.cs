using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public ActionResult Index()
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee { EmpNo = 1, Name = "Rushikesh", Basic = 10000, DeptNo = 10 });
            list.Add(new Employee { EmpNo = 2, Name = "Shubh", Basic = 20000, DeptNo = 20 });
            list.Add(new Employee { EmpNo = 3, Name = "Tom", Basic = 30000, DeptNo = 30 });
            return View(list);
        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int id=1)
        {
            Employee obj = new Employee();
            obj.EmpNo = id;
            obj.Name = "Rushikesh";
            obj.Basic = 100000;
            obj.DeptNo = 10;

            return View(obj);
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        { 
            return View();
        }

        // POST: EmployeesController/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        string name = collection["Name"];
        //        string empNo = collection["EmpNo"];
        //        string basic = collection["Basic"];
        //        string deptNo = collection["DeptNo"];


        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(string Name,int EmpNo,decimal Basic,int DeptNo)
        //{
        //    try
        //    {


        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee obj)
        {
            try
            {


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }




        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee obj = new Employee();
            obj.EmpNo = id;
            obj.Name = "Rushikesh";
            obj.Basic = 100000;
            obj.DeptNo = 10;
            return View(obj);
        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee obj)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee obj = new Employee();
            obj.EmpNo = id;
            obj.Name = "Rushikesh";
            obj.Basic = 100000;
            obj.DeptNo = 10;
            return View(obj);
        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee obj)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
