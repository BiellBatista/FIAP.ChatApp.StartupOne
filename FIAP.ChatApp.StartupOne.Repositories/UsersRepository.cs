using FIAP.ChatApp.StartupOne.DL;
using FIAP.ChatApp.StartupOne.Models;
using FIAP.ChatApp.StartupOne.Repositories.Common;
using FIAP.ChatApp.StartupOne.Repositories.Interfaces;

namespace FIAP.ChatApp.StartupOne.Repositories
{
    public class UsersRepository : GenericRepository<UserModel>, IUsersRepository
    {
        public UsersRepository(ChatAppContext context) : base(context)
        {
        }
    }
}