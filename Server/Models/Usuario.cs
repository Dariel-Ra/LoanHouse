
using System.ComponentModel.DataAnnotations;
using LoanHouse.Shared.Records;
using LoanHouse.Shared.Requests;

namespace LoanHouse.Server.Models;

public class Usuario
{
    public Usuario()
    {
        
    }
    public Usuario(int usuarioRolId, string name, string nickname, string password)
    {
        UsuarioRolId = usuarioRolId;
        Name = name;
        Nickname = nickname;
        Password = password;
    }

    [Key]
    public int Id { get; set; }
    public int UsuarioRolId { get; set; }
    public string Name { get; set; } = null!;
    public string Nickname { get; set; } = null!;
    public string Password { get; set; } = null!;
    public virtual UsuarioRol UsuarioRol { get; set; } = null!;

    public static Usuario Crear(UsuarioCreateRequest request)
    {
            return new Usuario(){ 
             
            UsuarioRolId = request.UsuarioRolId,
            Name = request.Name,
            Nickname = request.Nickname, 
            Password = request.Password 
            };
        // return new Usuario(request.UsuarioRolId,request.Name, request.Nickname, request.Password);
    }
    public void Modificar(UsuarioUpdateRequest request){
        if(Name!=request.Name) 
            Name = request.Name;
        if(UsuarioRolId!= request.UsuarioRolId) 
            UsuarioRolId = request.UsuarioRolId;
        if(Nickname!=request.Nickname) 
            Nickname = request.Nickname;
        if(Password!= request.Password) 
            Password = request.Password;
    }

    public UsuarioRecord ToRecord()
    {
        return new UsuarioRecord(Id,UsuarioRol.ToRecord(),Name,Nickname,Password);
    }
}