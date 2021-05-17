using FIAP.ChatApp.StartupOne.DL;
using FIAP.ChatApp.StartupOne.Repositories.Interfaces;
using System;

namespace FIAP.ChatApp.StartupOne.Repositories.Common
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {

        private ChatAppContext dbContext;

        private bool disposed = false;

        public UnitOfWork(ChatAppContext context)
        {
            dbContext = context;
        }

        public void Commit()
        {
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool isDisposed)
        {
            if (!disposed)
            {
                if (!isDisposed)
                {
                    dbContext.Dispose();
                }
            }

            disposed = true;
        }
    }
}
