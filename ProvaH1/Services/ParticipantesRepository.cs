using ProvaH1.Models;

namespace ProvaH1.Services
{
    public class ParticipantesRepository : IParticipantesRepository
    {
        private static List<Participante> listaParticipantes = [];

        public void AdicionarParticipante(Participante novoParticipante)
        {
            listaParticipantes.Add(novoParticipante);
        }

        public List<Participante> ListarParticipantes()
        {
            return listaParticipantes;
        }
    }
}
