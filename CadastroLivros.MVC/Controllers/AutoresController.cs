using CadastroLivros.Application.Interfaces;
using CadastroLivros.Application.Model;
using CadastroLivros.Application.Transformation;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CadastroLivros.MVC.Controllers
{
    public class AutoresController : Controller
    {
        private readonly IAppAutorService _autorApp;

        public AutoresController(IAppAutorService autorApp)
        {
            _autorApp = autorApp;
        }

        // GET: Autores
        public ActionResult Index()
        {
            IEnumerable<AutorModel> autorModel = new AutorTransformation().TransformarAutorEmAutorModel(_autorApp.GetAll());
            return View(autorModel);
        }

        // GET: Autores/Details/5
        public ActionResult Details(int id)
        {
            var autor = _autorApp.GetById(id);
            var autorModel = new AutorTransformation().TransformarAutorEmAutorModel(autor);
            return View(autorModel);
        }

        // GET: Autores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autores/Create
        [HttpPost]
        public ActionResult Create(AutorModel autorModel)
        {
            if (ModelState.IsValid)
            {
                var autor = new AutorTransformation().TransformarAutorModelEmAutor(autorModel);
                _autorApp.Add(autor);

                return RedirectToAction("Index");
            }

            return View(autorModel);
        }

        // GET: Autores/Edit/5
        public ActionResult Edit(int id)
        {
            var autor = _autorApp.GetById(id);
            var autorModel = new AutorTransformation().TransformarAutorEmAutorModel(autor);
            return View(autorModel);
        }

        // POST: Autores/Edit/5
        [HttpPost]
        public ActionResult Edit(AutorModel autorModel)
        {
            if (ModelState.IsValid)
            {
                var autor = new AutorTransformation().TransformarAutorModelEmAutor(autorModel);
                _autorApp.Update(autor);

                return RedirectToAction("Index");
            }

            return View(autorModel);
        }

        // GET: Autores/Delete/5
        public ActionResult Delete(int id)
        {
            var autor = _autorApp.GetById(id);
            var autorModel = new AutorTransformation().TransformarAutorEmAutorModel(autor);
            
            return View(autorModel);
        }

        // POST: Autores/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var autor = _autorApp.GetById(id);
            _autorApp.Remove(autor);

            return RedirectToAction("Index");
        }
    }
}