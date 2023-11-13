using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Cita,CitaDto>().ReverseMap(); //Tome la entidad Pais y mappeela de acuerdo a la estructura del DTO esto permite de entidad a DTO y de DTO a entidad
        CreateMap<Ciudad,CiudadDto>().ReverseMap();
        CreateMap<Cliente,ClienteDto>().ReverseMap();
        CreateMap<ClienteTelefono,ClienteTelefonoDto>().ReverseMap();
        CreateMap<Departamento,DepartamentoDto>().ReverseMap();
        CreateMap<Mascota,MascotaDto>().ReverseMap();
        CreateMap<Pais,PaisDto>().ReverseMap();
        CreateMap<Raza,RazaDto>().ReverseMap();
        CreateMap<Servicio,ServicioDto>().ReverseMap();
        CreateMap<Departamento,DepartamentoListaCiudadDto>().ReverseMap();
    }
}
