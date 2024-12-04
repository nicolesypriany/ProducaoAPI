using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProducaoAPI.Data;
using ProducaoAPI.Models;
using ProducaoAPI.Requests;

namespace ProducaoAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MaquinaController : ControllerBase
    {
        private readonly ProducaoContext _context;

        public MaquinaController(ProducaoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Maquina>>> ListarMaquinas()
        {
            var maquinas = await _context.Maquinas.ToListAsync();
            if (maquinas == null) return NotFound();
            return Ok(maquinas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Maquina>> BuscarMaquinaPorId(int id)
        {
            var maquina = await _context.Maquinas.FindAsync(id);
            if(maquina == null) return NotFound();
            return Ok(maquina);
        }

        [HttpPost]
        public async Task<ActionResult<Maquina>> CadastrarMaquina(MaquinaRequest req)
        {
            var maquina = new Maquina(req.Nome, req.Marca);
            await _context.Maquinas.AddAsync(maquina);
            await _context.SaveChangesAsync();
            return Ok(maquina);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Maquina>> AtualizarMaquina(int id, MaquinaRequest req)
        {
            var maquina = await _context.Maquinas.FindAsync(id);
            if (maquina == null) return NotFound();

            maquina.Nome = req.Nome;
            maquina.Marca = req.Marca;

            await _context.SaveChangesAsync();
            return Ok(maquina);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Maquina>> DeletarMaquina(int id)
        {
            var maquina = await _context.Maquinas.FindAsync(id);
            if (maquina == null) return NotFound();

             _context.Maquinas.Remove(maquina);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
