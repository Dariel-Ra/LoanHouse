using System.Net.Cache;
using System.Data;
using Ardalis.ApiEndpoints;
using LoanHouse.Server.Context;
using LoanHouse.Shared.Requests;
using LoanHouse.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using LoanHouse.Server.Models;
using Microsoft.EntityFrameworkCore;
using LoanHouse.Shared.Routes;


namespace LoanHouse.Server.Endpoints.Usuarios;

using Request = UsuarioCreateRequest;
using Respuesta = Result<int>;

public class Create : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;

    public Create(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpPost(UsuarioRouteManager.BASE)]
    public override async Task<ActionResult<Respuesta>> HandleAsync(Request request, CancellationToken cancellationToken = default)
    {
        try
        {
            #region  Validaciones
            var usuario = await dbContext.Usuarios.FirstOrDefaultAsync(
                r => r.Name.ToLower() == request.Name.ToLower(),cancellationToken); 
            if(usuario != null)
                return Respuesta.Fail($"Ya existe un rol con el nombre '({request.Name})'.");
            #endregion
            usuario = Usuario.Crear(request);
            dbContext.Usuarios.Add(usuario);
            await dbContext.SaveChangesAsync(cancellationToken);
            return Respuesta.Success(usuario.Id);
        }
        catch(Exception e){
            return Respuesta.Fail(e.Message);
        }
    }
}