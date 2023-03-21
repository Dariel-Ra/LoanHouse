namespace LoanHouse.Shared.Requests;

public class PagoCreateRequest
{

    public int Fecha_pago { get; set; }
    public float Monto { get; set; }
    public int PrestamoId { get; set; }
    public int UsuarioId { get; set; }
}
public class PagoUpdateRequest: PagoCreateRequest{
    public int Id { get; set; }
}