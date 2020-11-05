using CadastroLivros.Application.Model;
using CadastroLivros.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace CadastroLivros.Application.Transformation
{
    public class AutorTransformation
    {
        public AutorModel TransformarAutorEmAutorModel(Autor autor)
        {
            var autorModel = new AutorModel();
                autorModel.Id = autor.Id;
                autorModel.Nome = autor.Nome;

            return autorModel;
        }

        public IEnumerable<AutorModel> TransformarAutorEmAutorModel(IEnumerable<Autor> autores)
        {
            foreach(var autor in autores)
            {
                yield return TransformarAutorEmAutorModel(autor);
            }
        }

        public Autor TransformarAutorModelEmAutor(AutorModel autorModel)
        {
            var autor = new Autor();
                autor.Id = autorModel.Id;
                autor.Nome = autorModel.Nome;

            return autor;
        }

        public IEnumerable<Autor> TransformarAutorModelEmAutor(IEnumerable<AutorModel> autoresModel)
        {
            foreach(var autorModel in autoresModel)
            {
                yield return TransformarAutorModelEmAutor(autorModel);
            }
        }
    }
}
