using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repositories;
public class RolRepository : GenericRepository<Rol>,IRolRepository
{
    private readonly VeterinaryAppContext _context;

    public RolRepository(VeterinaryAppContext context) : base(context)
    {
        _context = context;
    }
}
