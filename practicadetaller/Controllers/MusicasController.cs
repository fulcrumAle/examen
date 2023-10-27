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
    public class MusicasController : ControllerBase
    {

        private readonly ILogger<MusicasController> _logger;
        private readonly AplicacionContexto _aplicacionContexto;

        public MusicasController(ILogger<MusicasController> logger, AplicacionContexto aplicacionContexto)
        {
            _logger = logger;
            _aplicacionContexto = aplicacionContexto;
        }
        [Route("")]
        [HttpGet]
        public IEnumerable<Musica> GetEstudiante()
        {

            return _aplicacionContexto.Musica.ToList();
        }
        [Route("/DeleteMusica")]
        [HttpDelete]
        public IActionResult Delete(int musicaID)
        {
            _aplicacionContexto.Musica.Remove(_aplicacionContexto.Musica.ToList().Where(x => x.idMusica == musicaID).FirstOrDefault());
            _aplicacionContexto.SaveChanges();
            return Ok(musicaID);
        }
        [Route("/PostMusica")]
        [HttpPost]
        public IActionResult Post([FromBody] Musica musica)
        {
            _aplicacionContexto.Musica.Add(musica);
            _aplicacionContexto.SaveChanges();
            return Ok(musica);
        }
        [Route("/PutMusica")]
        [HttpPut]
        public IActionResult Put([FromBody] Musica musica)
        {
            _aplicacionContexto.Musica.Update(musica);
            _aplicacionContexto.SaveChanges();
            return Ok(musica);
        }
    }
}

