using AutoMapper;
using PCInfo_backend.Recommendations.Domain.Models;
using PCInfo_backend.Recommendations.Resource;
using Monitor = PCInfo_backend.Recommendations.Domain.Models.Monitor;


namespace PCInfo_backend.Recommendations.Mapping;
// Desde la clase Model a la clase Resource (Base de Datos)
public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        // CreateMap<Source, Destination>();
        CreateMap<CPU, CPUResource>();
        CreateMap<DiscoDuro, DiscoDuroResource>();
        CreateMap<GPU, GPUResource>();
        CreateMap<Monitor, MonitorResource>();
        CreateMap<Producto, ProductoResource>();
        CreateMap<RAM, RAMResource>();
        CreateMap<Teclado, TecladoResource>();
    }
}