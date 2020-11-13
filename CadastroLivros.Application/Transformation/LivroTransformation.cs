using CadastroLivros.Application.Model;
using CadastroLivros.Domain.Entities;
using System.Collections.Generic;

namespace CadastroLivros.Application.Transformation
{
    public class LivroTransformation
    {
        public LivroModel TransformarLivroEmLivroModel(Livro livro)
        {
            var livroModel = new LivroModel();
            livroModel.Id = livro.Id;
            livroModel.Editora = livro.Editora;
            livroModel.Edicao = livro.Edicao;
            livroModel.AnoPublicação = livro.AnoPublicacao;
            livroModel.Valor = livro.Valor;
            livroModel.Autores = livro.Autores;

            return livroModel;
        }

        public IEnumerable<LivroModel> TransformarLivroEmLivroModel(IEnumerable<Livro> livros)
        {
            foreach (var livro in livros)
            {
                yield return TransformarLivroEmLivroModel(livro);
            }
        }

        public Livro TransformarLivroModelEmLivro(LivroModel livroModel)
        {
            var livro = new Livro();
            livro.Id = livroModel.Id;
            livro.Editora = livroModel.Editora;
            livro.Edicao = livroModel.Edicao;
            livro.AnoPublicacao = livroModel.AnoPublicação;
            livro.Valor = livroModel.Valor;
            livro.Autores = livroModel.Autores;

            return livro;
        }

        public IEnumerable<Livro> TransformarLivroModelEmLivro(IEnumerable<LivroModel> livrosModel)
        {
            foreach (var livroModel in livrosModel)
            {
                yield return TransformarLivroModelEmLivro(livroModel);
            }
        }
    }
}
