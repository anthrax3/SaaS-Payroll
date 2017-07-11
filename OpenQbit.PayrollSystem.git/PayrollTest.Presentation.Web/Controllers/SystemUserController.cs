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
    public class SystemUserController : Controller
    {

        // GET: TestAPI
        public async Task<ActionResult> GetSystemUser()
        {

            WebClient client = new WebClient();
            SystemUser systemUser = await client.GetSystemUser();

            return View(systemUser);
        }

        // GET: SystemUser
        public ActionResult Index()
        {
            return View();
        }

        // GET: SystemUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SystemUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SystemUser/Create
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

        // GET: SystemUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SystemUser/Edit/5
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

        // GET: SystemUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SystemUser/Delete/5
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
