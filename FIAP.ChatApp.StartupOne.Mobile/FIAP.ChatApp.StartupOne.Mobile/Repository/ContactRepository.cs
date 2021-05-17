using FIAP.ChatApp.StartupOne.Mobile.Config;
using FIAP.ChatApp.StartupOne.Mobile.Models;
using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace FIAP.ChatApp.StartupOne.Repository
{
    public class ContactRepository : IDisposable
    {
        private SQLite.SQLiteConnection connection;

        public ContactRepository()
        {
            var dbConfig = DependencyService.Get<IDbPathConfig>();
            var caminho = Path.Combine(dbConfig.Path, "startupOne.db");
            connection = new SQLite.SQLiteConnection(caminho);
            connection.CreateTable<ContactModel>();
        }

        public IList<ContactModel> GetList()
        {
            return connection.Table<ContactModel>().ToList();
        }

        public ContactModel Get(int id)
        {
            return connection.Table<ContactModel>().Where(i => i.Id == id).FirstOrDefault();
        }

        public void Insert(ContactModel model)
        {
            connection.Insert(model);
        }

        public void Update(ContactModel model)
        {
            connection.Update(model);
        }

        public void Delete(ContactModel model)
        {
            connection.Delete(model);
        }

        public void DropTable()
        {
            connection.DropTable<ContactModel>();
        }

        public void Dispose()
        {
            if (connection != null)
            {
                connection.Dispose();
            }
        }
    }
}