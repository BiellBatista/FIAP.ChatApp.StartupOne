using FIAP.ChatApp.StartupOne.Models;
using System.Collections.Generic;

namespace FIAP.ChatApp.StartupOne.Managers.Interfaces
{
    public interface IConversationsManager
    {
        IEnumerable<ConversationModel> GetAllConversationsByUserId(long userId);

        ConversationModel GetConversationByUsersId(long firstUser, long secondUser);

        long AddOrUpdateConversation(long firstUser, long secondUser);

        void AddReply(string message, long conversationId, long userID);
    }
}