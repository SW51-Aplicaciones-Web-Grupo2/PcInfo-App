using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Shared.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services.Communication;

public class TecladoResponse : BaseResponse<Teclado>
{
    public TecladoResponse(string message) : base(message)
    {
    }

    public TecladoResponse(Teclado resource) : base(resource)
    {
    }
}