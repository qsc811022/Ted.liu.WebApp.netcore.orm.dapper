using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class FoodController : Controller
    {
        DemoProvider service = new DemoProvider();
        // GET: FoodController
        public ActionResult Index()
        {
            var data = service.GetllData();
            return View(data);
        }

        // GET: FoodController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FoodController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FoodController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection,FoodModel model)
        {
            try
            {
                service.Create(model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodController/Edit/5
        public ActionResult Edit(int id)
        {
            var data =service.GetId(id);
            return View(data);
        }

        // POST: FoodController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection,FoodModel model)
        {
            try
            {
                service.Edit(id,model);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FoodController/Delete/5
        public ActionResult Delete(int id)
        {
            var data = service.GetId(id);
            return View(data);
        }

        // POST: FoodController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                service.Delete(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
