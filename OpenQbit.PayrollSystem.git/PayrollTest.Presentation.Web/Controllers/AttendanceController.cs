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
    public class AttendanceController : Controller
    {
        // GET: TestAPI
        public async Task<ActionResult> GetAttendance()
        {

            WebClient client = new WebClient();
            Attendance attendance = await client.GetAttendance();

            return View(attendance);
        }

        // GET: Attendance
        public ActionResult Index()
        {
            return View();
        }

        // GET: Attendance/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Attendance/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Attendance/Create
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

        // GET: Attendance/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Attendance/Edit/5
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

        // GET: Attendance/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Attendance/Delete/5
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
