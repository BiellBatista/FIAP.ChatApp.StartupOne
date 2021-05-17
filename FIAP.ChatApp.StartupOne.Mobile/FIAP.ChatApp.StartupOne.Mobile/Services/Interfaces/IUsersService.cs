using FIAP.ChatApp.StartupOne.Mobile.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FIAP.ChatApp.StartupOne.Mobile.Services.Interfaces
{
    public interface IUsersService
    {
        Task<IEnumerable<UserModel>> GetUserFriendsAsync(long userId);
    }
}