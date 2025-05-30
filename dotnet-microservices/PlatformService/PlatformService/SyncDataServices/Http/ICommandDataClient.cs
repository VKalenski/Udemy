#region Usings
using System.Threading.Tasks;
using PlatformService.Dtos;
#endregion

namespace PlatformService.SyncDataServices.Http
{
    public interface ICommandDataClient
    {
        Task SendPlatformToCommand(PlatformReadDto plat); 
    }
}