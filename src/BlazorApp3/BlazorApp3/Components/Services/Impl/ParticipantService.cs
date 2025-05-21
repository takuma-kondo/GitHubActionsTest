using BlazorApp3.Components.Models;

namespace BlazorApp3.Components.Services.Impl
{
    public class ParticipantService : IParticipantService
    {
        private List<Participant> _participants = new List<Participant>();
        private List<Participant> _winners = new List<Participant>();

        public List<Participant> GetParticipants()
        {
            return _participants;
        }

        public void AddParticipant(Participant participant)
        {
            if (!_participants.Any(p => p.EmployeeNumber == participant.EmployeeNumber))
            {
                _participants.Add(participant);
            }
        }

        public void AddParticipants(IEnumerable<Participant> newParticipants)
        {
            foreach (var participant in newParticipants)
            {
                AddParticipant(participant);
            }
        }

        public void RemoveParticipant(Participant participant)
        {
            _participants.Remove(participant);
        }

        public void ClearParticipants()
        {
            _participants.Clear();
            _winners.Clear();
        }

        public void ResetWinningStatus()
        {
            foreach (var participant in _participants)
            {
                participant.HasWon = false;
            }
            _winners.Clear();
        }

        public void MarkAsWinner(Participant participant)
        {
            var winningParticipant = _participants.FirstOrDefault(p => p.EmployeeNumber == participant.EmployeeNumber);
            if (winningParticipant != null)
            {
                winningParticipant.HasWon = true;
                AddWinner(winningParticipant);
            }
        }

        public List<Participant> GetWinners()
        {
            return _winners;
        }

        public void AddWinner(Participant winner)
        {
            if (!_winners.Contains(winner))
            {
                _winners.Add(winner);
            }
        }

        public void ClearWinners()
        {
            _winners.Clear();
        }

        public bool IsValidParticipant(int employeeNumber, string name)
        {
            return _participants.Any(p =>
                p.EmployeeNumber == employeeNumber &&
                p.Name == name);
        }
    }
}
