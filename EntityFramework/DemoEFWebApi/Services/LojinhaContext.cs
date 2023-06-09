using Microsoft.EntityFrameworkCore;
using DemoEFWebApi.Models;

namespace DemoEFWebApi.Services;

public class LojinhaContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; } = null!;
    public DbSet<Produto> Produtos { get; set; } = null!;
    public DbSet<Pedido> Pedidos { get; set; } = null!;

    public LojinhaContext()
    {
        
    }

    public LojinhaContext(DbContextOptions<LojinhaContext> options)
        :base(options)
    {
        
    }

    //CUSTOMIZAÇÃO DO MAPEAMENTO DO ENTITY FRAMEWORK PRA DATABASE
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(EntityBuilder => {
            EntityBuilder.Property(e => e.Nome).HasMaxLength(30);
            EntityBuilder.Property(e => e.Email).HasMaxLength(50);
        });

        modelBuilder.Entity<Produto>(EntityBuilder => {
            EntityBuilder.Property(e => e.Nome).HasMaxLength(30);
            EntityBuilder.Property(e => e.Descricao).HasMaxLength(200);
        });

        // CUIDAR AQUI - configurar somente um dos lados do mapeamento da tabela associativa. Nesse caso vamos configurar Pedido e não Produto
        modelBuilder.Entity<Pedido>()
                    .HasMany(pedido => pedido.Produtos)
                    .WithMany(produto => produto.Pedidos)
                    .UsingEntity<Item>();
    }
}