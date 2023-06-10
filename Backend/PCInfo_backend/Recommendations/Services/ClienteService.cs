using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Recommendations.Domain.Repositories;
using PCInfo_backend.Recommendations.Domain.Services;
using PCInfo_backend.Recommendations.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Services;

public class ClienteService : IClienteService
{
    private readonly IClienteService _clienteService;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IUserService _userService;

    public ClienteService(IClienteService clienteService, IUnitOfWork unitOfWork, IUserService userService)
    {
        _clienteService = clienteService;
        _unitOfWork = unitOfWork;
        _userService = userService;
    }

    public async Task<IEnumerable<Cliente>> ListAsync()
    {
        return await _clienteService.ListAsync();
    }

    public async Task<ClienteResponse> GetAsync(int id)
    {
        return await _clienteService.GetAsync(id);
    }

    public async Task<ClienteResponse> SaveAsync(Cliente cliente)
    {
        try
        {
            await _clienteService.SaveAsync(cliente);
            await _unitOfWork.completeAsync();
            return new ClienteResponse(cliente);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ClienteResponse> UpdateAsync(int id, Cliente cliente)
    {
        //Validate Cliente
        var existingCliente = await _clienteService.GetAsync(id);
        if (existingCliente == null)
            return new ClienteResponse("Cliente not found");
        existingCliente = cliente;
        try
        {
            await _clienteService.UpdateAsync(id, cliente);
            await _unitOfWork.completeAsync();
            return ClienteResponse(existingCliente);
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    public async Task<ClienteResponse> DeleteAsync(int id)
    {
        try
        {
            var existingCliente = await _clienteService.GetAsync(id);
            await _clienteService.DeleteAsync(id);
            await _unitOfWork.completeAsync();
            return existingCliente;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}