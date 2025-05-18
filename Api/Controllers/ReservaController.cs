using clean_code_refactor.Domain.Bases;
using clean_code_refactor.Domain.Services.Reservas;
using clean_code_refactor.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace clean_code_refactor.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReservaController(IReservaService service) : ControllerBase
    {
        private readonly IReservaService _service = service;

        [HttpGet]
        public async Task<IActionResult> GetAsync() => Ok(await _service.Recuperar());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAsync([FromRoute] int id)
        {
            var result = await _service.Recuperar(id);

            return result.Success && result.Value != null
                ? Ok(result.Value)
                : BadRequest(result);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CriarReservaViewModel dto)
        {
            try
            {
                var result = await _service.Inserir(dto);
                return result.Success
                    ? Ok(result.Value)
                    : BadRequest(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
