using clean_code_refactor.Domain.Services.Reservas;
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
            var reserva = _service.Recuperar(id);
            return reserva == null ? NotFound() : Ok(reserva);
        }
    }
}
