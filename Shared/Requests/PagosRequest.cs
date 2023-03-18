namespace LoanHouse.Shared.Records;

public class PagosRequest
{
    public int Pago_id { get; set; }
    public int Fecha_pago { get; set; }
    public float Monto { get; set; }
    public int Prestamo_id { get; set; }
    public int Usuario_id { get; set; }
}