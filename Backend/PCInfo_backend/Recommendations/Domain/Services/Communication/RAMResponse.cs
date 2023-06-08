using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Shared.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services.Communication;

public class RAMResponse : BaseResponse<RAM>
{
    public RAMResponse(string message) : base(message)
    {
    }

    public RAMResponse(RAM resource) : base(resource)
    {
    }
}