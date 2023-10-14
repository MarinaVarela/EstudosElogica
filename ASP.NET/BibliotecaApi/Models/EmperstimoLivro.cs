using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaApi.Models
{
        public class EmprestimoLivro
        {
            [Key]
            public int Id { get; set; }

            [Required]
            public int EmprestimoId { get; set; }

            [Required]
            public int LivroId { get; set; }

            // Relação com a tabela de empréstimos
            [ForeignKey(nameof(EmprestimoId))]
            public Emprestimos? Emprestimo { get; set; }

            // Tabela de livros
            [ForeignKey(nameof(LivroId))]
            public Livros? Livro { get; set; }
        }
    }
