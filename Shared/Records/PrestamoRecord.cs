namespace LoanHouse.Shared.Records;
public class PrestamoRecord
{
    public PrestamoRecord(){

    }
    public PrestamoRecord(int id, int fecha_prestamo, double monto, int tasa_interes, int plazo, ClienteRecord cliente, UsuarioRecord usuario)
    {
        Id = id;
        Fecha_prestamo = fecha_prestamo;
        Monto = monto;
        Tasa_interes = tasa_interes;
        Plazo = plazo;
        Cliente = cliente;
        Usuario = usuario;
    }

    public int Id { get; set; }
    public int Fecha_prestamo { get; set; }
    public double Monto { get; set; }
    public int Tasa_interes { get; set; }
    public int Plazo { get; set; }
    public virtual ClienteRecord Cliente { get; set; } = null!;
    public virtual UsuarioRecord Usuario { get; set; } = null!;
}