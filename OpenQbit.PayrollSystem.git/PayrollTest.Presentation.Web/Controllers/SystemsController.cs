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
    public class SystemsController : Controller
    {
        // GET: TestAPI
        public async Task<ActionResult> GetSystems()
        {

            WebClient client = new WebClient();
            Systems systems = await client.GetSystems();

            return View(systems);
        }

        // GET: Systems
        public ActionResult Index()
        {
            return View();
        }

        // GET: Systems/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Systems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Systems/Create
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

        // GET: Systems/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Systems/Edit/5
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

        // GET: Systems/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Systems/Delete/5
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
