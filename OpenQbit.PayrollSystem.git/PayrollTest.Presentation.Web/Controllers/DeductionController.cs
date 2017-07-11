using PayrollTest.Presentation.Web.Models;
using PayrollTest.Presentation.Web.WebAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PayrollTest.Presentation.Web.Controllers
{
    public class DeductionController : Controller
    {

        // GET: TestAPI
        public async Task<ActionResult> GetDeduction()
        {

            WebClient client = new WebClient();
            Deduction deduction = await client.GetDeduction();

            return View(deduction);
        }

        // GET: Deduction
        public ActionResult Index()
        {
            return View();
        }

        // GET: Deduction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Deduction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Deduction/Create
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

        // GET: Deduction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Deduction/Edit/5
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

        // GET: Deduction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Deduction/Delete/5
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
