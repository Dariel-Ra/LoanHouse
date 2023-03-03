using Ardalis.ApiEndpoints;
using LoanHouse.Server.Context;
using LoanHouse.Server.Models;
using LoanHouse.Shared.Records;
using LoanHouse.Shared.Routes;
using LoanHouse.Shared.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoanHouse.Server.Endpoints.UsuariosRoles;
using Respuesta = ResultList<UsuarioRolRecord>;

public class Get : EndpointBaseAsync.WithoutRequest.WithActionResult<Respuesta>
{
    private readonly IMyDbContext dbContext;

    public Get(IMyDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    [HttpGet(UsuarioRolRouteManager.BASE)]
    public override async Task<ActionResult<Respuesta>> HandleAsync(CancellationToken cancellationToken = default)
    {
       try
       {
        var roles = await dbContext.UsuariosRoles
       .Select(rol=>rol.ToRecord())
       .ToListAsync(cancellationToken);

       return Respuesta.Success(roles);
       }
       catch(Exception ex)
       {
        return Respuesta.Fail(ex.Message);
       }
    }
}