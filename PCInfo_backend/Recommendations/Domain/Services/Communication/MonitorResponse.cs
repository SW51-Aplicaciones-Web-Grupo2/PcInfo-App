using PCInfo_backend.Shared.Domain.Services.Communication;
using Monitor = PCInfo_backend.Recommendations.Domain.Models.Monitor;

namespace PCInfo_backend.Recommendations.Domain.Services.Communication;

public class MonitorResponse : BaseResponse<Monitor>
{
    public MonitorResponse(string message) : base(message)
    {
    }

    public MonitorResponse(Monitor resource) : base(resource)
    {
    }
}