using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Shared.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services.Communication;

public class CPUResponse : BaseResponse<CPU>
{
    public CPUResponse(string message) : base(message)
    {
    }

    public CPUResponse(CPU resource) : base(resource)
    {
    }
}