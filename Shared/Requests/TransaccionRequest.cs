namespace LoanHouse.Shared.Records;

public class TransaccionRequest{

    public int Transaccion_id { get; set; }
    public int Fecha { get; set; }
    public float Monto { get; set; }
    public int Prestamos_id { get; set; }
    public int Usuario_id { get; set; }
}