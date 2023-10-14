using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AlunoApi.Models;

namespace AlunoApi.Data
{
    public class AlunoDbContext : DbContext
    {
        public AlunoDbContext (DbContextOptions<AlunoDbContext> options)
            : base(options)
        {
        }

        public DbSet<AlunoApi.Models.Alunos> Alunos { get; set; } = default!;
    }
}
