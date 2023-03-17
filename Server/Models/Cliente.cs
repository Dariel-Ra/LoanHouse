using System.ComponentModel.DataAnnotations;

namespace LoanHouse.Server.Models;

public class Cliente
{
    public Cliente(int cliente_id, string nombre, string apellido, string dirección, string pais, string ciudad, string cedula, string telefono)
    {
        Cliente_id = cliente_id;
        Nombre = nombre;
        Apellido = apellido;
        Dirección = dirección;
        Pais = pais;
        Ciudad = ciudad;
        Cedula = cedula;
        Telefono = telefono;
    }

    [Key]
    public int Cliente_id { get; set; }
    public string Nombre {get; set; } = null!;
    public string Apellido {get; set; } = null!;
    public string Dirección {get; set; } = null!;
    public string Pais {get; set; } = null!;
    public string Ciudad {get; set; } = null!;
    public string Cedula {get; set; } = null!;
    public string Telefono {get; set; } = null!;
}
