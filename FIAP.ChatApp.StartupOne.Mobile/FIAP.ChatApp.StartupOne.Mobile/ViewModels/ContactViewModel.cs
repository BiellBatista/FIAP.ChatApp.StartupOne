using FIAP.ChatApp.StartupOne.Mobile.Models;
using FIAP.ChatApp.StartupOne.Repository;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Xamarin.Forms;

namespace FIAP.ChatApp.StartupOne.Mobile.ViewModels
{
    public class ContactViewModel : INotifyPropertyChanged
    {
        private ContactRepository repository;

        public ContactViewModel()
        {
            repository = new ContactRepository();
            ContactsInMemory = new ObservableCollection<ContactModel>(repository.GetList());

            GravarClickedCommand = new Command(() =>
            {
                var mensagem = "Dados do contato alterados com sucesso!";
                try
                {
                    ContactModel model = new ContactModel()
                    {
                        Name = name,
                        Email = email
                    };

                    repository.Insert(model);

                    // Atualizando a lista
                    ContactsInMemory = new ObservableCollection<ContactModel>(repository.GetList());
                }
                catch (Exception ex)
                {
                    mensagem = "Não foi possível alterar os dados do contato. Verifique sua conexão! \n Detalhe: " +
                        ex.Message;
                }

                Application.Current.MainPage.DisplayAlert("Contato", mensagem, "OK");
            });
        }

        private ObservableCollection<ContactModel> contacts;

        public ObservableCollection<ContactModel> ContactsInMemory
        {
            get { return contacts; }
            set
            {
                if (contacts != value)
                {
                    contacts = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int id;

        public int Id
        {
            get { return id; }
            set
            {
                if (id != value)
                {
                    id = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string email;

        public string Email
        {
            get { return email; }
            set
            {
                if (email != value)
                {
                    email = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public ICommand GravarClickedCommand { get; private set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}