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
    public class LeavesController : Controller
    {
        // GET: TestAPI
        public async Task<ActionResult> GetLeaves()
        {

            WebClient client = new WebClient();
            Leaves leaves = await client.GetLeaves();

            return View(leaves);
        }

        // GET: Leaves
        public ActionResult Index()
        {
            return View();
        }

        // GET: Leaves/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Leaves/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Leaves/Create
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

        // GET: Leaves/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Leaves/Edit/5
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

        // GET: Leaves/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Leaves/Delete/5
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
