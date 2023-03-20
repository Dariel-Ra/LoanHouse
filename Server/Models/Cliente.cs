using System.ComponentModel.DataAnnotations;

namespace LoanHouse.Server.Models;

public class Cliente
{
    [Key]
    public int Id { get; set; }
    public string Nombre {get; set; } = null!;
    public string Apellido {get; set; } = null!;
    public string Dirección {get; set; } = null!;
    public string Pais {get; set; } = null!;
    public string Ciudad {get; set; } = null!;
    public string Cedula {get; set; } = null!;
    public string Telefono {get; set; } = null!;
}
