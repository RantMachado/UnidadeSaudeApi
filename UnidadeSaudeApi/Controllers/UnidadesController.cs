using UnidadeSaudeApi.Models;
using UnidadeSaudeApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace UnidadeSaudeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnidadesController : ControllerBase
    {
        private readonly UnidadeService _unidadeService;

        public UnidadesController(UnidadeService unidadeService)
        {
            _unidadeService = unidadeService;
        }

        [HttpGet]
        public ActionResult<List<Unidade>> Get() =>
            _unidadeService.Get();

        [HttpGet("{id:length(24)}", Name ="GetUnidade")]
        public ActionResult<Unidade> Get(string id)
        {
            var unidade = _unidadeService.Get(id);

            if (unidade == null)
            {
                return NotFound();
            }

            return unidade;
        }

        [HttpPost]
        public ActionResult<Unidade> Create(Unidade unidade)
        {
            _unidadeService.Create(unidade);

            return CreatedAtRoute("GetUnidade", new { id = unidade.Id.ToString() }, unidade);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Unidade unidadeIn)
        {
            var unidade = _unidadeService.Get(id);

            if (unidade == null)
            {
                return NotFound();
            }

            _unidadeService.Update(id, unidadeIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var unidade = _unidadeService.Get(id);

            if (unidade == null)
            {
                return NotFound();
            }

            _unidadeService.Remove(unidade.Id);

            return NoContent();
        }
    }
}
