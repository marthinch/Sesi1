using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //if (EntryUsername.Text == null || EntryUsername.Text == "")
            //{
            //    await DisplayAlert("Warning", "Username kosong", "OK");
            //}

            if (string.IsNullOrEmpty(EntryUsername.Text))
            {
                await DisplayAlert("Warning", "Username kosong", "OK");
            }
            else if (string.IsNullOrEmpty(EntryPassword.Text))
            {
                await DisplayAlert("Warning", "Password kosong", "OK");
            }
            else
            {
                await DisplayAlert("Success", "User valid", "OK");
            }
        }
    }
}
