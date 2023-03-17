namespace LoanHouse.Shared.Records;

public class ClienteRequest
{
    public int Cliente_id { get; set; }
    public string Nombre {get; set; } = null!;
    public string Apellido {get; set; } = null!;
    public string Dirección {get; set; } = null!;
    public string Cedula {get; set; } = null!;
    public string Telefono {get; set; } = null!;
}
