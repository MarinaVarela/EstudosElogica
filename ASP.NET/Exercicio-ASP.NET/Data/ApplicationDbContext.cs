using Microsoft.EntityFrameworkCore;
using ExercicioASPNET.Models;
public class ApplicationDbContext : DbContext
{
    public DbSet<Estudante> Estudantes { get; set; } 

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("AddBancoDeDados"); // adicionar aqui as configurações do sqlserver
    }
}

