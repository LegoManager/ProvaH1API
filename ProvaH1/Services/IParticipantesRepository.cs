using ProvaH1.Models;

namespace ProvaH1.Services
{
    public interface IParticipantesRepository
    {
        void AdicionarParticipante(Participante novoParticipante);
        List<Participante> ListarParticipantes();
    }
}
