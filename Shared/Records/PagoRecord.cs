namespace LoanHouse.Shared.Records;

public class PagoRecord
{
    public PagoRecord(int id, int fecha_pago, float monto, PrestamoRecord prestamos, UsuarioRecord usuario)
    {
        Id = id;
        Fecha_pago = fecha_pago;
        Monto = monto;
        Prestamos = prestamos;
        Usuario = usuario;
    }

    public int Id { get; set; }
    public int Fecha_pago { get; set; }
    public float Monto { get; set; }
    public virtual PrestamoRecord Prestamos { get; set; } = null!;
    public virtual UsuarioRecord Usuario { get; set; } = null!;
}