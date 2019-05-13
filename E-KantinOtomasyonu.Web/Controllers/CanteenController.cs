using E_KantinOtomasyonu.BLL.Repository;
using E_KantinOtomasyonu.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_KantinOtomasyonu.Web.Controllers
{
    public class CanteenController : Controller
    {
        // GET: Canteen
        public ActionResult Index()
        {
            var canteenRepo = new CanteenRepo();

            return View(canteenRepo.Listele());
        }

        // GET: Canteen/Details/5
        //public ActionResult Details(int id)
        //{
        //     return View();
        //}

        // GET: Canteen/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Canteen/Create
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

        // GET: Canteen/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Canteen/Edit/5
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

        // GET: Canteen/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Canteen/Delete/5
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
