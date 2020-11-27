using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDMTP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Login_Clicked(object sender, System.EventArgs e)
        {
            var id = IDEntry.Text;
            var pass = PassEntry.Text;
            
            if(id == "admin" && pass == "senha@admin")
            {
                DisplayAlert("Sucesso!", "O usuário logou com sucesso!", "Ok");
            }
            else
            {
                DisplayAlert("Error!", "Login inválido!", "Ok");
            }
        }

        private void Clean_Clicked(object sender, System.EventArgs e)
        {
            IDEntry.Text = "";
            PassEntry.Text = "";
        }

        private void Credits_Clicked(object sender, System.EventArgs e)
        {
            DisplayAlert("Autores", "Saulo SIlva Castilhos 1740318", "Ok");
        }
    }
}
