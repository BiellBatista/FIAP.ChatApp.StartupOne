﻿using FIAP.ChatApp.StartupOne.Mobile.Services.Interfaces;
using Prism.Mvvm;
using Prism.Navigation;

namespace FIAP.ChatApp.StartupOne.Mobile.ViewModels
{
    public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible
    {
        protected INavigationService NavigationService { get; private set; }

        private string _title;
        protected readonly ISessionService SessionService;

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService, ISessionService sessionService)
        {
            NavigationService = navigationService;
            this.SessionService = sessionService;
        }

        public virtual void Initialize(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedFrom(INavigationParameters parameters)
        {
        }

        public virtual void OnNavigatedTo(INavigationParameters parameters)
        {
        }

        public virtual void Destroy()
        {
        }
    }
}