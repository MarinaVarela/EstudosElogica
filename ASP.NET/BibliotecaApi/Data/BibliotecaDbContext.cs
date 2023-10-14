using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BibliotecaApi.Models;

namespace BibliotecaApi.Data
{
    public class BibliotecaDbContext : DbContext
    {
        public BibliotecaDbContext (DbContextOptions<BibliotecaDbContext> options)
            : base(options)
        {
        }

        public DbSet<BibliotecaApi.Models.Usuarios> Usuarios { get; set; } = default!;

        public DbSet<BibliotecaApi.Models.Livros>? Livros { get; set; }

        public DbSet<BibliotecaApi.Models.Emprestimos>? Emprestimos { get; set; }

        public DbSet<BibliotecaApi.Models.EmprestimoLivro>? EmprestimoLivro { get; set; }
    }
}
