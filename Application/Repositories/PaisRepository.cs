using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repositories;
public class PaisRepository : GenericRepository<Pais>,IPaisRepository
{
    private readonly VeterinaryAppContext _context;

    public PaisRepository(VeterinaryAppContext context) : base(context)
    {
        _context = context;
    }

    public async Task<Pais> GetPaisByNameDepartamento(string name)
    {
        return await _context.Paises.Where(x=>x.NombrePais.Trim().ToLower() == name.Trim().ToLower())
        .Include(x=>x.Departamentos)
        .ThenInclude(x=>x.Ciudades)
        .FirstAsync();
    }
}
