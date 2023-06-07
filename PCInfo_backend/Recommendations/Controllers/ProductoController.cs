using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Recommendations.Domain.Services;
using PCInfo_backend.Recommendations.Resource;

namespace PCInfo_backend.Recommendations.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class ProductoController
{
    private readonly IProductoService _productoService;
    private readonly IMapper _mapper;
    
    public ProductoController(IProductoService productoService, IMapper mapper)
    {
        _productoService = productoService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<ProductoResource>> getAllAsync()
    {
        // Retrieve a collection of Producto objects asynchronously
        var productos = await _productoService.ListAsync();

        // Map the Producto objects to a collection of ProductoResource objects using AutoMapper
        var resources = _mapper.Map<IEnumerable<Producto>, IEnumerable<ProductoResource>>(productos);

        // Return the collection of ProductoResource objects
        return resources;
    }
    
}
