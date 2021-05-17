using FIAP.ChatApp.StartupOne.DL;
using FIAP.ChatApp.StartupOne.Models;
using FIAP.ChatApp.StartupOne.Repositories.Common;
using FIAP.ChatApp.StartupOne.Repositories.Interfaces;

namespace FIAP.ChatApp.StartupOne.Repositories
{
    public class TokensRepository : GenericRepository<RefreshTokenModel>, ITokensRepository
    {
        public TokensRepository(ChatAppContext context)
            : base(context)
        {
        }
    }
}