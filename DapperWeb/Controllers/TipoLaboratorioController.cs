using DapperWeb._2_Dapper;
using DapperWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DapperWeb.Controllers
{
    public class TipoLaboratorioController : Controller
    {
        TipoLaboratorio _lab = new TipoLaboratorio();
        // GET: TipoLaboratorio
        public ActionResult Index()
        {
            return View(_lab.listar());
        }

        // GET: TipoLaboratorio/Details/5
        public ActionResult Details(int id)
        {
            return View(_lab.BuscarPorID(id));
        }

        // GET: TipoLaboratorio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoLaboratorio/Create
        [HttpPost]
        public ActionResult Create(Laboratorio item)
        {
            try
            {
                // TODO: Add insert logic here
                _lab.insert(item);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoLaboratorio/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_lab.BuscarPorID(id));
        }

        // POST: TipoLaboratorio/Edit/5
        [HttpPost]
        public ActionResult Edit(Laboratorio laboratorio)
        {
            try
            {
                // TODO: Add update logic here
                _lab.Update(laboratorio);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: TipoLaboratorio/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_lab.BuscarPorID(id));
        }

        // POST: TipoLaboratorio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Laboratorio laboratorio)
        {
            try
            {
                // TODO: Add delete logic here
                _lab.Delete(id, laboratorio);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
