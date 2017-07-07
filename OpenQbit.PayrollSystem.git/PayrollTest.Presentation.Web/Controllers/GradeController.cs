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
    public class GradeController : Controller
    {

        // GET: TestAPI
        public async Task<ActionResult> GetGrade()
        {

            WebClient client = new WebClient();
            Grade grade = await client.GetGrade();

            return View(grade);
        }

        // GET: Grade
        public ActionResult Index()
        {
            return View();
        }

        // GET: Grade/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Grade/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Grade/Create
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

        // GET: Grade/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Grade/Edit/5
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

        // GET: Grade/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Grade/Delete/5
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
