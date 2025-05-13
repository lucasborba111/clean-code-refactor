using clean_code_refactor.Data;
using clean_code_refactor.Models;
using clean_code_refactor.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace clean_code_refactor.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpGet("clientes")]
        public async Task<IActionResult> GetAsync([FromServices] AppDbContext context)
        {
            var clientes = await context
                .Clientes
                .AsNoTracking()
                .ToListAsync();

            return Ok(clientes);
        }

        [HttpGet("cliente/{id}")]
        public async Task<IActionResult> GetAByIdAsync([FromServices] AppDbContext context, [FromRoute] int id)
        {
            var cliente = await context
                .Clientes
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == id);

            return cliente == null 
                ? NotFound() 
                : Ok(cliente);
        }

        [HttpPost("Cliente")]
        public async Task<IActionResult> PostAsync([FromServices] AppDbContext contexto, [FromBody] CriarClienteViewModel clienteViewModel)
        {
            if (!ModelState.IsValid)
                return BadRequest("Exitem campos a preencher!");

            try
            {
                Cliente cliente = new()
                {
                    Cpf = clienteViewModel.Cpf,
                    Nome = clienteViewModel.Nome
                };

                await contexto.Clientes.AddAsync(cliente);
                await contexto.SaveChangesAsync();

                return Created($"/clientes/{cliente.Id}", cliente);
            }
            catch
            {
                return BadRequest("Não foi possível criar cliente");
            }
        }
    }
}
