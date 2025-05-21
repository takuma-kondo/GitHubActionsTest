using BlazorApp3.Components.Models;

namespace BlazorApp3.Components.Services
{
    public interface IParticipantService
    {
        List<Participant> GetParticipants();
        void AddParticipant(Participant participant);
        void AddParticipants(IEnumerable<Participant> newParticipants);
        void RemoveParticipant(Participant participant);
        void ClearParticipants();
        void ResetWinningStatus();
        void MarkAsWinner(Participant participant);
        List<Participant> GetWinners();
        void AddWinner(Participant winner);
        void ClearWinners();
        bool IsValidParticipant(int employeeNumber, string name);
    }
}
