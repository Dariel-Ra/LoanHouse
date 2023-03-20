namespace LoanHouse.Shared.Requests;
public class PrestamosRequest
{
    public int Id { get; set; }
    public int Fecha_prestamo { get; set; }
    public float Monto { get; set; }
    public int Tasa_interes { get; set; }
    public int Plazo { get; set; }
    public int ClienteId { get; set; }
    public int UsuarioId { get; set; }
}