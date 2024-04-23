using ClassificadosApi.Models;
using ClassificadosApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassificadosApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassificadosController : ControllerBase
    {
        private IClassificadoServices _classificadoService;

        public ClassificadosController(IClassificadoServices classificadoService)
        {
            _classificadoService = classificadoService;
        }
        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<Classificado>>> GetClassificados()
        {
            try
            {
                var classificados = await _classificadoService.GetClassificados();
                return Ok(classificados);
            }
            catch 
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Could not find classificados");
            }
        }
        [HttpGet("OrdenadoPorData")]
        public async Task<ActionResult<IAsyncEnumerable<Classificado>>> GetClassificadosByData()
        {
            try
            {
                var classificados = await _classificadoService.GetClassificadosByData();
                return Ok(classificados);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Could not find classificados");
            }
        }
        [HttpGet("{id:int}", Name = "GetClassificado")]
        public async Task<ActionResult<Classificado>> GetClassificado(int id)
        {
            try
            {
                var classificado = await _classificadoService.GetClassificado(id);
                if (classificado == null)
                    return NotFound($"Id={id} inesxistente");
                return Ok(classificado);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Could not find classificados");
            }
        }
        [HttpPost]
        public async Task<ActionResult> Create(Classificado classificado)
        {
            try
            {
                await _classificadoService.CreateClassificado(classificado);
                return CreatedAtRoute(nameof(GetClassificado), new {id = classificado.Id}, classificado); 
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Could not find classificados");
            }
        }
    }
}
