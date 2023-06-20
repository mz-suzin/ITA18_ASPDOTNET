using Microsoft.EntityFrameworkCore;
using LaboratorioRestApi.Models;

namespace LaboratorioRestApi.Database;

public class DatabaseContext : DbContext
{

    public DbSet<Autor> Autores { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<Emprestimo> Emprestimo { get; set; }
     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Entity-Lab;Integrated Security=true;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>()
            .HasMany(autor => autor.Livros)
            .WithMany(livro => livro.Autores);

        modelBuilder.Entity<Livro>()
            .HasMany(livro => livro.Emprestimos)
            .WithOne(emprestimo => emprestimo.Livros);
    }
}