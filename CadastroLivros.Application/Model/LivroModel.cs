using CadastroLivros.Domain.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CadastroLivros.Application.Model
{
    public class LivroModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(40, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Preencha o campo Editora")]
        [MaxLength(40, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caracteres")]
        public string Editora { get; set; }

        [Required(ErrorMessage = "Preencha o campo Ediçao")]
        [Range(1, int.MaxValue, ErrorMessage = "Informe o número da edição")]
        public int Edicao { get; set; }

        [Required(ErrorMessage = "Informe o ano de publicação")]
        [RegularExpression("^[0-9]{4,4}$", ErrorMessage = "Deve ser informado o ano de publicação")]
        public string AnoPublicação { get; set; }

        [Required(ErrorMessage = "Preencha o Valor")]
        [DisplayFormat(DataFormatString = "{0:C}")]
        public double Valor { get; set; }

        public ICollection<Autor> Autores { get; set; }
        public ICollection<Assunto> Assuntos { get; set; }
    }
}
