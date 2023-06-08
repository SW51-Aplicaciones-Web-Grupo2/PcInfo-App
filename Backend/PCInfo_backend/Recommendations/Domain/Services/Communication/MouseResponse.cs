using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Shared.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services.Communication;

public class MouseResponse : BaseResponse<Mouse>
{
    public MouseResponse(string message) : base(message)
    {
    }

    public MouseResponse(Mouse resource) : base(resource)
    {
    }
}