using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ProjectCP
{
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }
        public async void BtnRegister1_Clicked(object sender, EventArgs e)
        {
            //new NavigationPage(new MainPage());
            await Navigation.PushAsync(new MainPage(), false);
        }
    }
}
