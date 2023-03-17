using System.ComponentModel.DataAnnotations;

namespace LoanHouse.Server.Models;

public class Pagos 
{
    [Key]
    public int Pago_id { get; set; }
    public int Fecha_pago { get; set; }
    public float Monto { get; set; }
    public int Prestamo_id { get; set; }
    public virtual Prestamos Prestamos { get; set; } = null!;
    public int Usuario_id { get; set; }
    public virtual Prestamos Usuario { get; set; } = null!;
}