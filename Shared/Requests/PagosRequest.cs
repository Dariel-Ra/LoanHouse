namespace LoanHouse.Shared.Records;

public class PagosRequest
{
    public int Id { get; set; }
    public int Fecha_pago { get; set; }
    public float Monto { get; set; }
    public int PrestamoId { get; set; }
    public int UsuarioId { get; set; }
}