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
    public class BonusController : Controller
    {

        // GET: TestAPI
        public async Task<ActionResult> GetBonus()
        {

            WebClient client = new WebClient();
            Bonus bonus = await client.GetBonus();

            return View(bonus);
        }

        // GET: Bonus
        public ActionResult Index()
        {
            return View();
        }

        // GET: Bonus/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Bonus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bonus/Create
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

        // GET: Bonus/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Bonus/Edit/5
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

        // GET: Bonus/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Bonus/Delete/5
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
