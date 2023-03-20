using Ardalis.ApiEndpoints;
using LoanHouse.Server.Context;
using LoanHouse.Server.Models;
using LoanHouse.Shared.Records;
using LoanHouse.Shared.Routes;
using LoanHouse.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanHouse.Server.Endpoints.Usuarios;
using Respuesta = Result<UsuarioRecord>;
using Request = UsuarioRouteManager;

public class GetById : EndpointBaseAsync.WithRequest<Request>.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;

    public GetById(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpGet(UsuarioRouteManager.GetById)]
    public override async Task<ActionResult<Respuesta>> HandleAsync([FromRoute] Request request,CancellationToken cancellationToken = default)
    {
       try
       {
            var usuario = await dbContext.Usuarios
            .Where(r=>r.Id == request.Id)
            .Select(usuario=>usuario.ToRecord())
            .FirstOrDefaultAsync(cancellationToken);

            if(usuario==null)
                return Respuesta.Fail($"No fue posible encontrar el rol '{request.Id}'");

            return Respuesta.Success(usuario);
       }
       catch(Exception ex)
       {
            return Respuesta.Fail(ex.Message);
       }
    }
}
