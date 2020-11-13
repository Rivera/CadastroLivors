using CadastroLivros.Application.Interfaces;
using CadastroLivros.Application.Model;
using CadastroLivros.Application.Transformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CadastroLivros.MVC.Controllers
{
    public class AssuntosController : Controller
    {
        private readonly IAppAssuntoService _assuntoApp;

        public AssuntosController(IAppAssuntoService assuntoApp)
        {
            _assuntoApp = assuntoApp;
        }

        // GET: Assuntos
        public ActionResult Index()
        {
            IEnumerable<AssuntoModel> assuntoModel = new AssuntoTransformation().TransformarAssuntoEmAssuntoModel(_assuntoApp.GetAll());
            return View(assuntoModel);
        }

        // GET: Assuntos/Details/5
        public ActionResult Details(int id)
        {
            var assunto = _assuntoApp.GetById(id);
            var assuntoModel = new AssuntoTransformation().TransformarAssuntoEmAssuntoModel(assunto);
            return View(assuntoModel);
        }

        // GET: Assuntos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Assuntos/Create
        [HttpPost]
        public ActionResult Create(AssuntoModel assuntoModel)
        {
            if (ModelState.IsValid)
            {
                var assunto = new AssuntoTransformation().TransformarAssuntoModelEmAssunto(assuntoModel);
                _assuntoApp.Add(assunto);

                return RedirectToAction("Index");
            }

            return View(assuntoModel);
        }

        // GET: Assuntos/Edit/5
        public ActionResult Edit(int id)
        {
            var assunto = _assuntoApp.GetById(id);
            var assuntoModel = new AssuntoTransformation().TransformarAssuntoEmAssuntoModel(assunto);
            return View(assuntoModel);
        }

        // POST: Assuntos/Edit/5
        [HttpPost]
        public ActionResult Edit(AssuntoModel assuntoModel)
        {
            if (ModelState.IsValid)
            {
                var assunto = new AssuntoTransformation().TransformarAssuntoModelEmAssunto(assuntoModel);
                _assuntoApp.Update(assunto);

                return RedirectToAction("Index");
            }

            return View(assuntoModel);
        }

        // GET: Assuntos/Delete/5
        public ActionResult Delete(int id)
        {
            var assunto = _assuntoApp.GetById(id);
            var assuntoModel = new AssuntoTransformation().TransformarAssuntoEmAssuntoModel(assunto);

            return View(assuntoModel);
        }

        // POST: Assuntos/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var assunto = _assuntoApp.GetById(id);
            _assuntoApp.Remove(assunto);

            return RedirectToAction("Index");
        }
    }
}
