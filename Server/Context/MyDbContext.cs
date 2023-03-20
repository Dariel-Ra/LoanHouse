using Microsoft.EntityFrameworkCore;
using LoanHouse.Server.Models;

namespace LoanHouse.Server.Context;

public interface IMyDbContext
{
    DbSet<UsuarioRol> UsuariosRoles { get; set; }
    DbSet<Usuario> Usuarios { get; set; }
    DbSet<Cliente> Clientes { set; get; }
    DbSet<Pago> Pagos { get; set; }
    DbSet<Prestamo> Prestamos { get; set; }
    DbSet<Transaccion> Transacciones { get; set; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public class MyDbContext : DbContext, IMyDbContext
{
    private readonly IConfiguration config;

    public MyDbContext(IConfiguration _config)
    {
        config = _config;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(config.GetConnectionString("sqlServerDB"));
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    #region Tablas de mi base de datos
    public DbSet<UsuarioRol> UsuariosRoles { set; get; } = null!;
    public DbSet<Usuario> Usuarios { set; get; } = null!;
    public DbSet<Cliente> Clientes { set; get; } = null!;
    public DbSet<Pago> Pagos { get; set; }= null!;
    public DbSet<Prestamo> Prestamos { get; set; }= null!;
    public DbSet<Transaccion> Transacciones { get; set; }= null!;
    #endregion
}