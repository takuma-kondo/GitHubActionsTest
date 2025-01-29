using BlazorApp3.Components.Models;

namespace BlazorApp3.Components.Services
{
    public interface ILotteryService
    {
        Participant SelectWinner(List<Participant> participants);
    }
}
