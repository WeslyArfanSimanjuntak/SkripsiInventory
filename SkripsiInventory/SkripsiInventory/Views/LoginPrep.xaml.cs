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
    public partial class LoginPrep : ContentPage
    {
        public LoginPrep()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing() {
            base.OnAppearing();
            await Task.Delay(1000);
            await Navigation.PushModalAsync(new NavigationPage(new LoginPage()));
            //await this.Navigation.PushAsync(new NavigationPage(new LoginPage()));
        }
    }
}