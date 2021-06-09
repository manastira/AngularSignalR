using System.Threading.Tasks;

namespace AngularSignalR.Models
{
    public interface IHubClient
    {
        Task BroadcastMessages();
    }
}
