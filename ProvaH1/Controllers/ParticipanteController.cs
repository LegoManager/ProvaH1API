using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvaH1.Services;
using ProvaH1.Models;

namespace ProvaH1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParticipanteController : ControllerBase
    {
        private readonly IParticipantesRepository _participanteRepository;

        public ParticipanteController(IParticipantesRepository participanteRepository)
        {
            _participanteRepository = participanteRepository;
        }

        [HttpPost]
        [Route("AdicionarParticipante")]
        public IActionResult AdicionarParticipante(Participante novoParticipante)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _participanteRepository.AdicionarParticipante(novoParticipante);

            return Ok("Participante adicionado com sucesso");
        }

        [HttpGet]
        [Route("ListarParticipantes")]
        public IActionResult ListarParticipantes()
        {
            var participantes = _participanteRepository.ListarParticipantes();

            return Ok(participantes);
        }
    }
}
