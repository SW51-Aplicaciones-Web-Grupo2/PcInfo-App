using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Shared.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services.Communication;

public class GPUResponse : BaseResponse<GPU>
{
    public GPUResponse(string message) : base(message)
    {
    }

    public GPUResponse(GPU resource) : base(resource)
    {
    }
}