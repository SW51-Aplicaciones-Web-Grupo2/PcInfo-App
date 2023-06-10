using PCInfo_backend.Recommendations.Domain.Models.Users;
using PCInfo_backend.Shared.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services.Communication;

public class ClienteResponse : BaseResponse<Cliente>
{
    public ClienteResponse(string message) : base(message)
    {
    }
    public ClienteResponse(Cliente resource) : base(resource)
    {
    }
}