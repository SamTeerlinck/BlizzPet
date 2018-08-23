using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using BlizzPetApp.View;

namespace BlizzPetApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void pickFamily_SelectedIndexChanged(object sender, EventArgs e)
        {
            Master master = new Master();
            master.Family = pickFamily.SelectedIndex;
            Navigation.PushAsync(master);
        }
    }
}