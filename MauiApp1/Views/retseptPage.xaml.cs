using Microsoft.Maui.Controls;
using System;

namespace Views
{
    public partial class retseptPage : ContentPage
    {
        public retseptPage()
        {
            InitializeComponent();
        }

        async void ExploreButton_Clicked(System.Object sender, System.EventArgs e)
                => Application.Current.MainPage = new NavigationPage(new PAGEEEE());
    }
}
