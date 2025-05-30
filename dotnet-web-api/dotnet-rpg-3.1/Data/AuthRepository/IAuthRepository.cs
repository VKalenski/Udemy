#region Usings
using dotnet_rpg.Models;
using System.Threading.Tasks;
#endregion

namespace dotnet_rpg.Data.AuthRepository
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExists(string username);
    }
}