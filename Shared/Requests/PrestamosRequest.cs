namespace LoanHouse.Shared.Requests;
public class PrestamosRequest
{
    public int Prestamos_id { get; set; }
    public int Fecha_prestamo { get; set; }
    public float Monto { get; set; }
    public int Tasa_interes { get; set; }
    public int Plazo { get; set; }
    public int Cliente_id { get; set; }
    public int Usuario_id { get; set; }
}