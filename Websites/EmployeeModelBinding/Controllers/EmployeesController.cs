﻿using EmployeeModelBinding.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System.Data;

namespace EmployeeModelBinding.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: EmployeesController
        public ActionResult Index()
        {
            

            List<Employee> empList=Employee.GetAllEmployees();
            return View(empList);


        }

        // GET: EmployeesController/Details/5
        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                Employee obj = Employee.GetEmployee(id.Value);
                if (obj != null)
                    return View(obj);
                else
                {
                    ViewBag.errmsg = "No such Employee Exists";
                    return View();
                }
            }
            else
                return NotFound();

           
        }

        // GET: EmployeesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EmployeesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee obj)
        {

            
            try
            {
                Employee.Insert(obj);
                ViewBag.errmsg = "Successfully Inserted";
                //return View();
                
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.errmsg = ex.Message;
                return View();
            }
        }

        // GET: EmployeesController/Edit/5
        public ActionResult Edit(int id)
        {
            Employee obj = Employee.GetEmployee(id);
            return View(obj);

        }

        // POST: EmployeesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Employee obj)
        {
            
            try
            {
                Employee.Update(obj);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.errmsg = ex.Message;
                return View();
            }
        }

        // GET: EmployeesController/Delete/5
        public ActionResult Delete(int id)
        {
            Employee obj=Employee.GetEmployee(id);
            return View(obj);

        }

        // POST: EmployeesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Employee obj)
        {
            
            try
            {
                Employee.Delete(id);
                return RedirectToAction(nameof(Index));

            }
            catch(Exception ex)
            {
                ViewBag.errmsg = ex.Message;
                return View();
            }

        }
    }
}
