using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArabaKirala.Controllers
{
    public class KisiController : Controller
    {
        // GET: KisiController
        public ActionResult Index()
        {
            return View();
        }

        // GET: KisiController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: KisiController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: KisiController/Create
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

        // GET: KisiController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: KisiController/Edit/5
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

        // GET: KisiController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: KisiController/Delete/5
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
