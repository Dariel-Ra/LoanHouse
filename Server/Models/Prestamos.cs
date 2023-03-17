using System.ComponentModel.DataAnnotations;

namespace LoanHouse.Server.Models;
    
public class Prestamos
{
    [Key]
    public int Prestamos_id { get; set; }
    public int Fecha_prestamo { get; set; }
    public float Monto { get; set; }
    public int Tasa_interes { get; set; }
    public int Plazo { get; set; }
    public int Cliente_id { get; set; }
    public virtual Cliente Cliente { get; set; } = null!;
    public int Usuario_id { get; set; }
    public virtual Prestamos Usuario { get; set; } = null!;
}
