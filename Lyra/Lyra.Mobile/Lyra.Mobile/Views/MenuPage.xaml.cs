using Lyra.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lyra.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Recommendations, Title="Recommendations" },
                new HomeMenuItem {Id = MenuItemType.Search, Title="Search" },
                new HomeMenuItem {Id = MenuItemType.Activity, Title="Activity" },
                new HomeMenuItem {Id = MenuItemType.YourMusic, Title="Your Music" },
                new HomeMenuItem {Id = MenuItemType.Settings, Title="Settings" },
                new HomeMenuItem {Id = MenuItemType.SignOut, Title="Sign Out" },
                new HomeMenuItem {Id = MenuItemType.RSIICovidExam, Title="RSIICovidExam" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}