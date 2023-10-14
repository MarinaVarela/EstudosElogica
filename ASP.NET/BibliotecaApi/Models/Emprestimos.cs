using System.ComponentModel.DataAnnotations;

namespace BibliotecaApi.Models
{
    public class Emprestimos
    {
            [Key]
            public int Id { get; set; }

            [Required]
            public DateTime DataEmprestimo { get; set; }

            [Required]
            public DateTime DataDevolucaoPrevista { get; set; }

            public DateTime? DataDevolucaoReal { get; set; }

            [Required]
            [MaxLength(20)]
            public string? Status { get; set; }

            public decimal Multa { get; set; }

            public int UsuarioId { get; set; }
            public Usuarios? Usuarios { get; set; }

            public ICollection<EmprestimoLivro>? EmprestimosLivros { get; set; }
        
    }
}
