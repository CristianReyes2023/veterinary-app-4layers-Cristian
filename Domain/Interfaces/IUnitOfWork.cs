using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces;
public interface IUnitOfWork
{
    ICitaRepository Citas { get; }
    ICiudadRepository Ciudades { get; }
    IClienteRepository Clientes { get; }
    IClienteDireccionRepository ClienteDirecciones { get; }
    IClienteTelefonoRepository ClienteTelefonos { get; }
    IDepartamentoRepository Departamentos { get; }
    IMascotaRepository Mascotas { get; }
    IPaisRepository Paises { get; }
    IRazaRepository Razas { get; }
    IServicioRepository Servicios { get; }
    IRefreshTokenRepository RefreshTokens {get;}
    IRolRepository Rols {get;}
    IUserRepository Users {get;}
    Task<int> SaveAsync();
}
