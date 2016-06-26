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
        public async void registerBtnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Register(), false);
        }
    }
}
