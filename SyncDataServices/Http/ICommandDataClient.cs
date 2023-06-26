using System.Threading.Tasks;
using dotNET_Microservices.DTO;

namespace dotNET_Microservices.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto platformReadDto);
    }
}