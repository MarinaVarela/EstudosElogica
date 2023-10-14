using System.ComponentModel.DataAnnotations;

namespace BibliotecaApi.Models
{
        public class Livros
        {
            [Key]
            public int Id { get; set; }

            [Required]
            [MaxLength(100)]
            public string? Titulo { get; set; }

            [Required]
            [MaxLength(100)]
            public string? Autor { get; set; }

            [Required]
            [MaxLength(50)]
            public string? Genero { get; set; }

            [Required]
            public int AnoPublicacao { get; set; }

            [Required]
            public int NumeroExemplares { get; set; }

            [Required]
            [MaxLength(20)]
            public string? Status { get; set; }

            public ICollection<EmprestimoLivro>? EmprestimosLivros { get; set; }
        }
    }
