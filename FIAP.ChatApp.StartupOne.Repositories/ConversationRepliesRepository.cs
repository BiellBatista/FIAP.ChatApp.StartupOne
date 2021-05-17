using FIAP.ChatApp.StartupOne.DL;
using FIAP.ChatApp.StartupOne.Models;
using FIAP.ChatApp.StartupOne.Repositories.Common;
using FIAP.ChatApp.StartupOne.Repositories.Interfaces;

namespace FIAP.ChatApp.StartupOne.Repositories
{
    public class ConversationRepliesRepository : GenericRepository<ConversationReplyModel>, IConversationRepliesRepository
    {
        public ConversationRepliesRepository(ChatAppContext context) : base(context)
        {
        }
    }
}