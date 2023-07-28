using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ola_Mundo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void BTNText_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Pages.Page1());
            DisplayAlert("Bem-Vindo", "Seja bem-vindo, " + TXTName.Text + "!", "OK");
        }
    }
}
