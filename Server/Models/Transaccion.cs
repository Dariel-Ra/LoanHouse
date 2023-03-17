using System.ComponentModel.DataAnnotations;

namespace LoanHouse.Server.Models;

public class Transaccion{
    [Key]
    public int Transaccion_id { get; set; }
    public int Fecha { get; set; }
    public float Monto { get; set; }
    public int Prestamos_id { get; set; }
    public virtual Prestamos Prestamos { get; set; } = null!;
    public int Usuario_id { get; set; }
    public virtual Prestamos Usuario { get; set; } = null!;
}