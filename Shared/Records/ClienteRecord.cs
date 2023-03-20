namespace LoanHouse.Shared.Records;

public class ClienteRecord
{
    public ClienteRecord(){
        
    }
    public ClienteRecord(int id, string nombre, string apellido, string dirección, string cedula, string telefono)
    {
        Id = id;
        Nombre = nombre;
        Apellido = apellido;
        Dirección = dirección;
        Cedula = cedula;
        Telefono = telefono;
    }

    public int Id { get; set; }
    public string Nombre {get; set; } = null!;
    public string Apellido {get; set; } = null!;
    public string Dirección {get; set; } = null!;
    public string Cedula {get; set; } = null!;
    public string Telefono {get; set; } = null!;
}
