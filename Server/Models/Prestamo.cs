using System.ComponentModel.DataAnnotations;

namespace LoanHouse.Server.Models;
    
public class Prestamo
{
    [Key]
    public int Id { get; set; }
    public int Fecha_prestamo { get; set; }
    public float Monto { get; set; }
    public int Tasa_interes { get; set; }
    public int Plazo { get; set; }
    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; } = null!;
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; } = null!;
}
