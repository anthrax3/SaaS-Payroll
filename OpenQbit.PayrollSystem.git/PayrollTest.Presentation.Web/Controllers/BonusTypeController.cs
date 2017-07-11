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
    public class BonusTypeController : Controller
    {

        // GET: TestAPI
        public async Task<ActionResult> GetBonusType()
        {

            WebClient client = new WebClient();
            BonusType bonusType = await client.GetBonusType();

            return View(bonusType);
        }

        // GET: BonusType
        public ActionResult Index()
        {
            return View();
        }

        // GET: BonusType/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BonusType/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BonusType/Create
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

        // GET: BonusType/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BonusType/Edit/5
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

        // GET: BonusType/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BonusType/Delete/5
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
