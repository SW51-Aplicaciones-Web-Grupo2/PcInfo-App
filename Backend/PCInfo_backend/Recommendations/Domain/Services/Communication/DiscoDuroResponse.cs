using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Shared.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services.Communication;

public class DiscoDuroResponse : BaseResponse<DiscoDuro>
{
    public DiscoDuroResponse(string message) : base(message)
    {
    }

    public DiscoDuroResponse(DiscoDuro resource) : base(resource)
    {
    }
}