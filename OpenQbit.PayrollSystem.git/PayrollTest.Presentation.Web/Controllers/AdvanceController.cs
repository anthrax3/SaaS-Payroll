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
    public class AdvanceController : Controller
    {

        // GET: TestAPI
        public async Task<ActionResult> GetAdvance()
        {

            WebClient client = new WebClient();
            Advance advance = await client.GetAdvance();

            return View(advance);
        }


        // GET: Advance
        public ActionResult Index()
        {
            return View();
        }

        // GET: Advance/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Advance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Advance/Create
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

        // GET: Advance/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Advance/Edit/5
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

        // GET: Advance/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Advance/Delete/5
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
