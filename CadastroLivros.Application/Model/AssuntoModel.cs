using System.ComponentModel.DataAnnotations;

namespace CadastroLivros.Application.Model
{
    public class AssuntoModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo Descrição")]
        [MaxLength(40, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(3, ErrorMessage = "Mínimo {0} caracteres")]
        public string Descricao { get; set; }
    }
}
