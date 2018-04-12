using DapperWeb._1_Infra.Dapper;
using DapperWeb.Models;
using System.Web.Mvc;

namespace DapperWeb.Controllers
{
    public class ProfessorController : Controller
    {
        TipoRecursoProfessor _TRP = new TipoRecursoProfessor();
        // GET: Professor
        public ActionResult Index()
        {
            return View(_TRP.listar());
        }

        // GET: Professor/Details/5
        public ActionResult Details(int id)
        {
            return View(_TRP.BuscarPorID(id));
        }

        // GET: Professor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professor/Create
        [HttpPost]
        public ActionResult Create(Professor Item)
        {
            try
            {
                // TODO: Add insert logic here
                _TRP.insert(Item);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Professor/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_TRP.BuscarPorID(id));
        }

        // POST: Professor/Edit/5
        [HttpPost]
        public ActionResult Edit(Professor professor)
        {
            try
            {
                _TRP.Update(professor);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Professor/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_TRP.BuscarPorID(id));
        }

        // POST: Professor/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Professor professor)
        {
            try
            {
                // TODO: Add delete logic here
                _TRP.Delete(id, professor);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }

        }
    }
}
