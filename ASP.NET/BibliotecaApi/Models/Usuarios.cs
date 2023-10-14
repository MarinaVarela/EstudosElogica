using System.ComponentModel.DataAnnotations;

namespace BibliotecaApi.Models
{
        public class Usuarios
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [MaxLength(50)]
            public string? Nome { get; set; }

            [Required]
            [MaxLength(50)]
            public string? Sobrenome { get; set; }

            [Required]
            [MaxLength(50)]
            public string? NomeUsuario { get; set; }

            [Required]
            [MaxLength(100)]
            public string? Senha { get; set; }

            [Required]
            [EmailAddress]
            [MaxLength(100)]
            public string? Email { get; set; }

            [Phone]
            [MaxLength(20)]
            public string? Telefone { get; set; }

            [Required]
            [MaxLength(20)]
            public string? Tipo { get; set; }

            public ICollection<Emprestimos>? Emprestimos { get; set; }
        }
    }

