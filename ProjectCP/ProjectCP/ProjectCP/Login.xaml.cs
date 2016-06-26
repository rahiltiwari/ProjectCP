using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ProjectCP
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }
        public async void RegisterBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register(), false);
        }
        public async void LoginBtn_Clicked(object sender, EventArgs e)
        {            
            //new NavigationPage(new MainPage());
            await Navigation.PushAsync(new MainPage(), false);
        }
    }
}
