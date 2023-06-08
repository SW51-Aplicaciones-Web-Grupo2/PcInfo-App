using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Shared.Domain.Services.Communication;

namespace PCInfo_backend.Recommendations.Domain.Services.Communication;

public class ProductoResponse : BaseResponse<Producto>
{
    public ProductoResponse(string message) : base(message)
    {
    }

    public ProductoResponse(Producto resource) : base(resource)
    {
    }
}