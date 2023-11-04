using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
    public class PaisController : BaseControllerApi
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        

        public PaisController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            
        }
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PaisDto>>> Get()
        {
            var paises = await _unitOfWork.Paises.GetAllAsync();
            // return Ok(entity);
            return _mapper.Map<List<PaisDto>>(paises);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]//Insertado correctamente
        [ProducesResponseType(StatusCodes.Status400BadRequest)]//La solicitud fue errada  
        public async Task<ActionResult<Pais>> Post(PaisDto paisDto)
        {
            var pais = _mapper.Map<Pais>(paisDto);
            _unitOfWork.Paises.Add(pais);
            await _unitOfWork.SaveAsync();
            if (pais == null)
            {
                return BadRequest();
            }
            paisDto.Id = pais.Id;
            return CreatedAtAction(nameof(Post), new { id = paisDto.Id }, paisDto);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]//Exitosamente
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PaisDto>> Put(int id, [FromBody] PaisDto paisDto)
        {
            if(paisDto == null)
                return NotFound();
            if(paisDto.Id == 0)
            {
                paisDto.Id = id;
            } 
            if(paisDto.Id != id)
            {
                return BadRequest();
            }
            var paises = _mapper.Map<Pais>(paisDto);
            _unitOfWork.Paises.Update(paises);
            await _unitOfWork.SaveAsync();
            return paisDto;
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var pais = await _unitOfWork.Paises.GetByIdAsync(id);//Ejecutamos el metodo Get para obtener el pais por el Id
            if (pais == null)
            {
                return NotFound();
            }
            _unitOfWork.Paises.Remove(pais);
            await _unitOfWork.SaveAsync();
            return NoContent();
        }
        [HttpGet("{Id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PaisDto>> Get(int Id)
        {
            var pais = await _unitOfWork.Paises.GetByIdAsync(Id);
            if (pais == null)
            {
                return NotFound();
            }
            return _mapper.Map<PaisDto>(pais);
        }
    }
}