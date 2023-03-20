namespace LoanHouse.Shared.Records;

public class TransaccionRecord{

    public int Id { get; set; }
    public int Fecha { get; set; }
    public float Monto { get; set; }
    public virtual PrestamoRecord Prestamos { get; set; } = null!;
    public virtual UsuarioRecord Usuario { get; set; } = null!;
}