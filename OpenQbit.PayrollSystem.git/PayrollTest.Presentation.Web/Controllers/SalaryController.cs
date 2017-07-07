﻿using PayrollTest.Presentation.Web.Models;
using PayrollTest.Presentation.Web.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PayrollTest.Presentation.Web.Controllers
{
    public class SalaryController : Controller
    {
        // GET: TestAPI
        public async Task<ActionResult> GetSalary()
        {

            WebClient client = new WebClient();
            Salary salary = await client.GetSalary();

            return View(salary);
        }

        // GET: Salary
        public ActionResult Index()
        {
            return View();
        }

        // GET: Salary/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Salary/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Salary/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Salary/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Salary/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Salary/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Salary/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
