using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace API.Dtos;
public class DepartamentoListaCiudadDto
{
    public int Id { get; set; }
    public string NombreDep { get; set; }
    public List<CiudadDto> Ciudades { get; set; }
}
