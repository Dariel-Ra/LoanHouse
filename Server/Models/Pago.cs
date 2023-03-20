using System.ComponentModel.DataAnnotations;

namespace LoanHouse.Server.Models;

public class Pago
{
    [Key]
    public int Id { get; set; }
    public int Fecha_pago { get; set; }
    public float Monto { get; set; }
    public int PrestamoId { get; set; }
    public virtual Prestamo Prestamo { get; set; } = null!;
    public int? UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; } = null!;
}