using Microsoft.AspNetCore.Mvc;
using practicadetaller.Models;
using Microsoft.AspNetCore.Mvc;
using practicadetaller.Models;
using Npgsql;
using practicadetaller.Context;

namespace practicadetaller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DiscosController : ControllerBase
    {

        private readonly ILogger<DiscosController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;

        public DiscosController(ILogger<DiscosController> logger, AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpGet]
        public IEnumerable<Disco> GetEstudiante()
        {

            return _aplicacionContexto.Disco.ToList();
        }
        [Route("/DeleteDisco")]
        [HttpDelete]
        public IActionResult Delete(int discoID)
        {
            _aplicacionContexto.Disco.Remove(_aplicacionContexto.Disco.ToList().Where(x => x.idDisco == discoID).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(discoID);
        }
        [Route("/PostDisco")]
        [HttpPost]
        public IActionResult Post([FromBody] Disco disco)
        {
            _aplicacionContexto.Disco.Add(disco);
            _aplicacionContexto.SaveChanges();
            return Ok(disco);
        }
        [Route("/PutDisco")]
        [HttpPut]
        public IActionResult Put([FromBody] Disco disco)
        {
            _aplicacionContexto.Disco.Update(disco);
            _aplicacionContexto.SaveChanges();
            return Ok(disco);
        }
    }
}
