using System.Data;
using Ardalis.ApiEndpoints;
using LoanHouse.Server.Context;
using LoanHouse.Shared.Requests;
using LoanHouse.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using LoanHouse.Server.Models;
using Microsoft.EntityFrameworkCore;
using LoanHouse.Shared.Routes;


namespace LoanHouse.Server.Endpoints.Clientes;

using Request = ClienteCreateRequest;
using Respuesta = Result<int>;

public class Create : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;

    public Create(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpPost(ClienteRouteManager.BASE)]
    public override async Task<ActionResult<Respuesta>> HandleAsync(Request request, CancellationToken cancellationToken = default)
    {
        try
        {
            #region  Validaciones
            var rol = await dbContext.Clientes.FirstOrDefaultAsync(r => r.Nombre.ToLower() == request.Nombre.ToLower(),cancellationToken); 
            if(rol != null)
                return Respuesta.Fail($"Ya existe un rol con el nombre '({request.Nombre})'.");
            #endregion
            rol = Cliente.Crear(request);
            dbContext.Clientes.Add(rol);
            await dbContext.SaveChangesAsync(cancellationToken);
            return Respuesta.Success(rol.Id);
        }
        catch(Exception e){
            return Respuesta.Fail(e.Message);
        }
    }
}