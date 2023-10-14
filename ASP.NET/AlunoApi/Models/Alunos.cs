using System.ComponentModel.DataAnnotations;

namespace AlunoApi.Models
{
    public class Alunos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Nome Completo")]
        [StringLength(255, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public int Idade { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres")]
        public string? Curso { get; set; }
    }
}
