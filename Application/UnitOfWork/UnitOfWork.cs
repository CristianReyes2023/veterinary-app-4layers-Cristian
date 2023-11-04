using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.UnitOfWork;
public class UnitOfWork : IUnitOfWork, IDisposable
{
    private ICitaRepository _citas;
    private ICiudadRepository _ciudades;
    private IClienteDireccionRepository _clientedirecciones;
    private IClienteRepository _clientes;
    private IClienteTelefonoRepository _clientetelefonos;
    private IDepartamentoRepository _departamentos;
    private IMascotaRepository _mascotas;
    private IPaisRepository _paises;
    private IRazaRepository _razas;
    private IServicioRepository _servicios;
    private IUserRepository _Users;
    private IRolRepository _Rols;
    private IRefreshTokenRepository _RefreshTokens;
    private readonly VeterinaryAppContext _context;

    public UnitOfWork(VeterinaryAppContext context)
    {
        _context = context;
    }
    public ICitaRepository Citas
    {
        get
        {
            if (_citas == null)
            {
                _citas = new CitaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _citas;
        }
    }
    public ICiudadRepository Ciudades
    {
        get
        {
            if (_ciudades == null)
            {
                _ciudades = new CiudadRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _ciudades;
        }
    }
    public IClienteDireccionRepository ClienteDirecciones
    {
        get
        {
            if (_clientedirecciones == null)
            {
                _clientedirecciones = new ClienteDirecciónRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _clientedirecciones;
        }
    }
    public IClienteRepository Clientes
    {
        get
        {
            if (_clientes == null)
            {
                _clientes = new ClienteRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _clientes;
        }
    }
    public IClienteTelefonoRepository ClienteTelefonos
    {
        get
        {
            if (_clientetelefonos == null)
            {
                _clientetelefonos = new ClienteTelefonoRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _clientetelefonos;
        }
    }
    public IDepartamentoRepository Departamentos
    {
        get
        {
            if (_departamentos == null)
            {
                _departamentos = new DepartamentoRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _departamentos;
        }
    }
    public IMascotaRepository Mascotas
    {
        get
        {
            if (_mascotas == null)
            {
                _mascotas = new MascotaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _mascotas;
        }
    }
    public IPaisRepository Paises
    {
        get
        {
            if (_paises == null)
            {
                _paises = new PaisRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _paises;
        }
    }
    public IRazaRepository Razas
    {
        get
        {
            if (_razas == null)
            {
                _razas = new RazaRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _razas;
        }
    }
    public IServicioRepository Servicios
    {
        get
        {
            if (_servicios == null)
            {
                _servicios = new ServicioRepository(_context); // Remember putting the base in the repository of this entity
            }
            return _servicios;
        }
    }

    public IUserRepository Users
    {
        get
        {
            if (_Users == null)
            {
                _Users = new UserRepository (_context); // Remember putting the base in the repository of this entity
            }
            return _Users;
        }
    }
    public IRolRepository Rols
    {
        get
        {
            if (_Rols == null)
            {
                _Rols = new RolRepository (_context); // Remember putting the base in the repository of this entity
            }
            return _Rols;
        }
    }
    public IRefreshTokenRepository RefreshTokens
    {
        get
        {
            if (_RefreshTokens == null)
            {
                _RefreshTokens = new RefreshTokenRepository (_context); // Remember putting the base in the repository of this entity
            }
            return _RefreshTokens;
        }
    }
    public void Dispose()
    {
        _context.Dispose();
    }
    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }
}
