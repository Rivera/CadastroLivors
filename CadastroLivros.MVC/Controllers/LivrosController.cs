using CadastroLivros.Application.Interfaces;
using CadastroLivros.Application.Model;
using CadastroLivros.Application.Transformation;
using System.Collections.Generic;
using System.Web.Mvc;

namespace CadastroLivros.MVC.Controllers
{
    public class LivrosController : Controller
    {
        private readonly IAppLivroService _livroApp;

        public LivrosController(IAppLivroService livroApp)
        {
            _livroApp = livroApp;
        }

        // GET: Autores
        public ActionResult Index()
        {
            IEnumerable<LivroModel> livroModel = new LivroTransformation().TransformarLivroEmLivroModel(_livroApp.GetAll());
            return View(livroModel);
        }

        // GET: Autores/Details/5
        public ActionResult Details(int id)
        {
            var livro = _livroApp.GetById(id);
            var livroModel = new LivroTransformation().TransformarLivroEmLivroModel(livro);
            return View(livroModel);
        }

        // GET: Autores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Autores/Create
        [HttpPost]
        public ActionResult Create(LivroModel livroModel)
        {
            if (ModelState.IsValid)
            {
                var livro = new LivroTransformation().TransformarLivroModelEmLivro(livroModel);
                _livroApp.Add(livro);

                return RedirectToAction("Index");
            }

            return View(livroModel);
        }

        // GET: Autores/Edit/5
        public ActionResult Edit(int id)
        {
            var livro = _livroApp.GetById(id);
            var livroModel = new LivroTransformation().TransformarLivroEmLivroModel(livro);
            return View(livroModel);
        }

        // POST: Autores/Edit/5
        [HttpPost]
        public ActionResult Edit(LivroModel livroModel)
        {
            if (ModelState.IsValid)
            {
                var livro = new LivroTransformation().TransformarLivroModelEmLivro(livroModel);
                _livroApp.Update(livro);

                return RedirectToAction("Index");
            }

            return View(livroModel);
        }

        // GET: Autores/Delete/5
        public ActionResult Delete(int id)
        {
            var livro = _livroApp.GetById(id);
            var livroModel = new LivroTransformation().TransformarLivroEmLivroModel(livro);
            
            return View(livroModel);
        }

        // POST: Autores/Delete/5
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var livro = _livroApp.GetById(id);
            _livroApp.Remove(livro);

            return RedirectToAction("Index");
        }
    }
}