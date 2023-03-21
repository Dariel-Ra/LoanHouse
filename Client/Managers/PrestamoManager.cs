using LoanHouse.Shared.Wrapper;
using LoanHouse.Shared.Records;
using LoanHouse.Shared.Requests;
using LoanHouse.Shared.Routes;
using LoanHouse.Client.Extensions;
using System.Net.Http.Json;

namespace LoanHouse.Client.Managers;

public interface IPrestamoManager
{
    Task<Result<int>> CreateAsync(PrestamoCreateRequest request);
    Task<ResultList<PrestamoRecord>> GetAsync();
    Task<Result<PrestamoRecord>> GetByIdAsync(int Id);
}

public class PrestamoManager : IPrestamoManager
{
    private readonly HttpClient httpClient;

    public PrestamoManager(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public async Task<ResultList<PrestamoRecord>> GetAsync()
    {
        try
        {
            var response = await httpClient.GetAsync(PrestamoRouteManager.BASE);
            var resultado = await response.ToResultList<PrestamoRecord>();
            return resultado;
        }
        catch (Exception e)
        {
            return ResultList<PrestamoRecord>.Fail(e.Message);
        }
    }
    public async Task<Result<int>> CreateAsync(PrestamoCreateRequest request)
    {
        var response = await httpClient.PostAsJsonAsync(PrestamoRouteManager.BASE, request);
        return await response.ToResult<int>();
    }
    public async Task<Result<PrestamoRecord>> GetByIdAsync(int Id)
    {
        var response = await httpClient.GetAsync(PrestamoRouteManager.BuildRoute(Id));
        return await response.ToResult<PrestamoRecord>();
    }
}