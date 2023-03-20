namespace LoanHouse.Shared.Records;

public class ClienteCreateRequest
{
    public string Nombre {get; set; } = null!;
    public string Apellido {get; set; } = null!;
    public string Dirección {get; set; } = null!;
    public string Cedula {get; set; } = null!;
    public string Telefono {get; set; } = null!;
}

public class ClienteUpdateRequest : ClienteCreateRequest
{
    public int Id { get; set; }
}
