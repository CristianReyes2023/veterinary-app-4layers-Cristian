using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories;
public class ServicioRepository : GenericRepository<Servicio>,IServicioRepository
{
    private readonly VeterinaryAppContext _context;

    public ServicioRepository(VeterinaryAppContext context) : base(context)
    {
        _context = context;
    }
}
