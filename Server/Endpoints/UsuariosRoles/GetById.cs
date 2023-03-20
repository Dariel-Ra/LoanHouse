using Ardalis.ApiEndpoints;
using LoanHouse.Server.Context;
using LoanHouse.Server.Models;
using LoanHouse.Shared.Records;
using LoanHouse.Shared.Routes;
using LoanHouse.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanHouse.Server.Endpoints.UsuariosRoles;
using Respuesta = Result<UsuarioRolRecord>;
using Request = UsuarioRolRouteManager;

public class GetById : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;

    public GetById(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpGet(UsuarioRolRouteManager.GetById)]
    public override async Task<ActionResult<Respuesta>> HandleAsync([FromRoute] Request request,CancellationToken cancellationToken = default)
    {
       try
       {
            var rol = await dbContext.UsuariosRoles
            .Where(r=>r.Id == request.Id)
            .Select(rol=>rol.ToRecord())
            .FirstOrDefaultAsync(cancellationToken);

            if(rol==null)
                return Respuesta.Fail($"No fue posible encontrar el rol '{request.Id}'");

            return Respuesta.Success(rol);
       }
       catch(Exception ex)
       {
            return Respuesta.Fail(ex.Message);
       }
    }
}
