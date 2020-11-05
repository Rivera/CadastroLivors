using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace CadastroLivros.Application.Model
{
    public class AutorModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(40, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(10, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
    }
}
