using System.ComponentModel.DataAnnotations;
using LoanHouse.Shared.Records;
using LoanHouse.Shared.Requests;

namespace LoanHouse.Server.Models;
    
public class Prestamo
{
    public Prestamo()
    {
    }

    public Prestamo(int fecha_prestamo, double monto, int tasa_interes, int plazo, int clienteId, int usuarioId)
    {
        Fecha_prestamo = fecha_prestamo;
        Monto = monto;
        Tasa_interes = tasa_interes;
        Plazo = plazo;
        ClienteId = clienteId;
        UsuarioId = usuarioId;
    }

    [Key]
    public int Id { get; set; }
    public int Fecha_prestamo { get; set; }
    public double Monto { get; set; }
    public int Tasa_interes { get; set; }
    public int Plazo { get; set; }
    public int ClienteId { get; set; }
    public virtual Cliente Cliente { get; set; } = null!;
    public int UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; } = null!;

    public static Prestamo Crear(PrestamoCreateRequest request)
    {
        return new Prestamo(){ 
            Fecha_prestamo = request.Fecha_prestamo,
            Monto = request.Monto,
            Tasa_interes = request.Tasa_interes,
            Plazo = request.Plazo,
            ClienteId = request.ClienteId,
            UsuarioId = request.UsuarioId
        };
    }
    public PrestamoRecord ToRecord()
    {
        return new PrestamoRecord(Id,Fecha_prestamo,Monto,Tasa_interes,Plazo,Cliente.ToRecord(),Usuario.ToRecord());
    }
}
