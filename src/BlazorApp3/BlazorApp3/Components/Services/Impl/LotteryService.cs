using BlazorApp3.Components.Models;

namespace BlazorApp3.Components.Services.Impl
{
    public class LotteryService : ILotteryService
    {
        private readonly Random _random = new();

        public Participant SelectWinner(List<Participant> participants)
        {
            if (participants == null || participants.Count == 0)
                throw new ArgumentException("参加者が存在しません");

            return participants[_random.Next(participants.Count)];
        }
    }
}
