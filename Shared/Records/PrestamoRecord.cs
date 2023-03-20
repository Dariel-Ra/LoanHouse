namespace LoanHouse.Shared.Records;
public class PrestamoRecord
{
    public int Id { get; set; }
    public int Fecha_prestamo { get; set; }
    public float Monto { get; set; }
    public int Tasa_interes { get; set; }
    public int Plazo { get; set; }
    public virtual ClienteRecord Cliente { get; set; } = null!;
    public virtual UsuarioRecord Usuario { get; set; } = null!;
}