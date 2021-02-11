using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InlämningsUppgift1ASP.Net.Controllers
{
    public class EditUserController : Controller
    {
        // GET: EditUserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: EditUserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EditUserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EditUserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EditUserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EditUserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EditUserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EditUserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
