using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;

namespace API.Dtos
{
    public class DepartamentoDto
    {
        public int Id { get; set; }
        public string NombreDep {get;set;}
        public int IdPaisFk {get;set;}
        // public PaisDto Pais { get; set; }
    }
}