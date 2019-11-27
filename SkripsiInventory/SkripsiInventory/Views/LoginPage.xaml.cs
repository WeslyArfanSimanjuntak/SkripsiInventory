using SkripsiInventory.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkripsiInventory.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BackgroundColor = Color.White;
            
        }


        async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            var ds = new InventoryDataStore();

            var result =await ds.GetItemAsync("2");
            
            if (!this.loadingIndicatorLogin.IsVisible)
            {
                this.loadingIndicatorLogin.IsEnabled = true;
                this.loadingIndicatorLogin.IsRunning = true;
                this.loadingIndicatorLogin.IsVisible = true;
            }
            else
            {
                this.loadingIndicatorLogin.IsEnabled = false;
                this.loadingIndicatorLogin.IsRunning = false;
                this.loadingIndicatorLogin.IsVisible = false;
            }
        }
    }
}