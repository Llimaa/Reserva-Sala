using DapperWeb._2_Dapper;
using DapperWeb.Models;
using System.Web.Mvc;

namespace DapperWeb.Controllers
{
    public class SalaController : Controller
    {
        TipoSala _sala = new TipoSala();
        // GET: Sala
        public ActionResult Index()
        {
            return View(_sala.listar());
        }

        // GET: Sala/Details/5
        public ActionResult Details(int id)
        {
            return View(_sala.BuscarPorID(id));
        }

        // GET: Sala/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sala/Create
        [HttpPost]
        public ActionResult Create(Sala sala)
        {
            try
            {
                // TODO: Add insert logic here
                _sala.insert(sala);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sala/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_sala.BuscarPorID(id));
        }

        // POST: Sala/Edit/5
        [HttpPost]
        public ActionResult Edit(Sala sala)
        {
            try
            {
                // TODO: Add update logic here
                _sala.Update(sala);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sala/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Sala/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Sala sala)
        {
            try
            {
                // TODO: Add delete logic here
                _sala.Delete(id, sala);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
