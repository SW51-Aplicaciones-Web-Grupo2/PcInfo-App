using AutoMapper;
using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Recommendations.Resource;
using Monitor = PCInfo_backend.Recommendations.Domain.Models.Monitor;

namespace PCInfo_backend.Recommendations.Mapping;
// Desde la clase Resource (Base de Datos) a la clase Model 
public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        // CreateMap<Source, Destination>();
        CreateMap<SaveCPUResource, CPU>();
        CreateMap<SaveDiscoDuroResource, DiscoDuro>();
        CreateMap<SaveGPUResource, GPU>();
        CreateMap<SaveMonitorResource, Monitor>();
        CreateMap<SaveProductoResource, Producto>();
        CreateMap<SaveRAMResource, RAM>();
        CreateMap<SaveTecladoResource, Teclado>();
    }
}