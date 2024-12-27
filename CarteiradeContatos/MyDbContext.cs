using CarteiradeContatos;
using Microsoft.EntityFrameworkCore;

public class MyDbContext : DbContext
{
    public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
    {
    }

    public DbSet<Contato> Contatos { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    // ... outras DbSet para suas entidades
}