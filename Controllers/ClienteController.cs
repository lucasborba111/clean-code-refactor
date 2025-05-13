using clean_code_refactor.Services.Clientes;
using clean_code_refactor.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace clean_code_refactor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController(IClienteService clienteService) : ControllerBase
    {
        #region ctor
        private readonly IClienteService _clienteService = clienteService;
        #endregion

        [HttpGet]
        public async Task<IActionResult> GetAsync() => Ok(await _clienteService.Recuperar());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAByIdAsync([FromRoute] int id)
        {
            var cliente = await _clienteService.Recuperar(id);

            return cliente == null ? NotFound() : Ok(cliente);
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] CriarClienteViewModel clienteViewModel)
        {
            try
            {
                return Ok(await _clienteService.Inserir(clienteViewModel));
            }
            catch
            {
                return BadRequest("Não foi possível criar cliente");
            }
        }
    }
}
