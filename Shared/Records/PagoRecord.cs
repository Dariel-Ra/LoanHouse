namespace LoanHouse.Shared.Records;

public class PagoRecord
{
    public int Pago_id { get; set; }
    public int Fecha_pago { get; set; }
    public float Monto { get; set; }
    public int Prestamo_id { get; set; }
    public virtual PrestamoRecord Prestamos { get; set; } = null!;
    public int Usuario_id { get; set; }
    public virtual UsuarioRecord Usuario { get; set; } = null!;
}