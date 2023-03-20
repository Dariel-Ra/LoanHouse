namespace LoanHouse.Shared.Records;

public class TransaccionRequest{

    public int Id { get; set; }
    public int Fecha { get; set; }
    public float Monto { get; set; }
    public int PrestamosId { get; set; }
    public int UsuarioId { get; set; }
}