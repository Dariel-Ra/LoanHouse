namespace LoanHouse.Shared.Records;

public class TransaccionRecord{

    public int Transaccion_id { get; set; }
    public int Fecha { get; set; }
    public float Monto { get; set; }
    public int Prestamos_id { get; set; }
    public virtual PrestamoRecord Prestamos { get; set; } = null!;
    public int Usuario_id { get; set; }
    public virtual UsuarioRecord Usuario { get; set; } = null!;
}