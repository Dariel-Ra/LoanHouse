using System.ComponentModel.DataAnnotations;
using LoanHouse.Shared.Records;
using LoanHouse.Shared.Requests;

namespace LoanHouse.Server.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }
    public string Nombre {get; set; } = null!;
    public string Apellido {get; set; } = null!;
    public string Dirección {get; set; } = null!;
    public string Cedula {get; set; } = null!;
    public string Telefono {get; set; } = null!;

    public static Cliente Crear(ClienteCreateRequest request)
    {
        return new Cliente(){ 
            Nombre = request.Nombre,
            Apellido = request.Apellido,
            Dirección = request.Dirección,
            Cedula = request.Cedula,
            Telefono = request.Telefono,
        };
    }
    public ClienteRecord ToRecord()
    {
        return new ClienteRecord(Id,Nombre,Apellido,Dirección,Cedula,Telefono);
    }
}
