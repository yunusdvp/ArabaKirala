using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArabaKirala.Controllers
{
    public class ArabaController : Controller
    {
        // GET: ArabaController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ArabaController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ArabaController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ArabaController/Create
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

        // GET: ArabaController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ArabaController/Edit/5
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

        // GET: ArabaController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ArabaController/Delete/5
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
