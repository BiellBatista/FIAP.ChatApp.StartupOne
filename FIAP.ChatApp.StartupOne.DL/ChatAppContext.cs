using FIAP.ChatApp.StartupOne.Models;
using Microsoft.EntityFrameworkCore;

namespace FIAP.ChatApp.StartupOne.DL
{
    public class ChatAppContext : DbContext
    {
        public DbSet<UserModel> Users { get; set; }
        public DbSet<FriendModel> Friends { get; set; }
        public DbSet<ConversationModel> Conversations { get; set; }
        public DbSet<ConversationReplyModel> ConversationReplies { get; set; }
        public DbSet<ConnectionModel> Connections { get; set; }
        public DbSet<RefreshTokenModel> RefreshTokens { get; set; }

        public ChatAppContext(DbContextOptions<ChatAppContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}