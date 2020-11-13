using CadastroLivros.Application.Model;
using CadastroLivros.Domain.Entities;
using System.Collections.Generic;

namespace CadastroLivros.Application.Transformation
{
    public class AssuntoTransformation
    {
        public AssuntoModel TransformarAssuntoEmAssuntoModel(Assunto assunto)
        {
            var assuntoModel = new AssuntoModel();
            assuntoModel.Id = assunto.Id;
            assuntoModel.Descricao = assunto.Descricao;

            return assuntoModel;
        }

        public IEnumerable<AssuntoModel> TransformarAssuntoEmAssuntoModel(IEnumerable<Assunto> assuntos)
        {
            foreach (var assunto in assuntos)
            {
                yield return TransformarAssuntoEmAssuntoModel(assunto);
            }
        }

        public Assunto TransformarAssuntoModelEmAssunto(AssuntoModel assuntoModel)
        {
            var assunto = new Assunto();
            assunto.Id = assuntoModel.Id;
            assunto.Descricao = assuntoModel.Descricao;

            return assunto;
        }

        public IEnumerable<Assunto> TransformarAssuntoModelEmAssunto(IEnumerable<AssuntoModel> assuntosModel)
        {
            foreach (var assuntoModel in assuntosModel)
            {
                yield return TransformarAssuntoModelEmAssunto(assuntoModel);
            }
        }
    }
}
