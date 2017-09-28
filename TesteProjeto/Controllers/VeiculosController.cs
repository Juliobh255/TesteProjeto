using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TesteProjeto.Controllers
{
    public class VeiculosController : Controller
    {
        // GET: Veiculos
        public ActionResult Index()
        {
            return View();
        }

        // GET: Veiculos/Details/5
        public ActionResult Details()
        {
            return View();
        }

        // GET: Veiculos/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Veiculos/Create
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

        // GET: Veiculos/Edit/5
        public ActionResult Edit()
        {
            return View();
        }

        // POST: Veiculos/Edit/5
        [HttpPost]
        public ActionResult Edit( FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }

        // GET: Veiculos/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Veiculos/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Details");
            }
            catch
            {
                return View();
            }
        }
    }
}
