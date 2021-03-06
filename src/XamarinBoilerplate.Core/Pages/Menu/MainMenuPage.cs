﻿using System;
using Autofac;
using Xamarin.Forms;
using XamarinBoilerplate.Core.Extensions;
using XamarinBoilerplate.Core.Services;

namespace XamarinBoilerplate.Core.Pages.Menu
{
    public class MainMenuPage : ContentPage, IDisposable
    {
        public MainMenuPage()
        {
            Title = "Menu";
            Content = new MainMenuView();

            var menuItemService = IoC.Container.Resolve<IMenuItemService>();
            var navigationService = IoC.Container.Resolve<INavigationService>();
            BindingContext = new MainMenuViewModel("Main Menu", "\u00A9 2017 XamarinBoilerplate, Inc.", menuItemService, navigationService);
        }

        public void Dispose()
        {
            this.DisposeContent();
            this.DisposeBindingContext();
        }
    }
}
