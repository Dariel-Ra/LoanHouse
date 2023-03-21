namespace LoanHouse.Shared.Requests;
public class PrestamoCreateRequest
{
    public int Fecha_prestamo { get; set; }
    public double Monto { get; set; }
    public int Tasa_interes { get; set; }
    public int Plazo { get; set; }
    public int ClienteId { get; set; }
    public int UsuarioId { get; set; }
}

public class PrestamoUpdateRequest: PrestamoCreateRequest {
    public int Id { get; set; }
}