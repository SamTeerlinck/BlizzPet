using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlizzPetApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {

        public string Family
        {
            get { return this.lblFamily.Text; }
            set { this.lblFamily.Text = value; }
        }

        public Master()
        {
            InitializeComponent();

        }



        void lvwPets_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Pet pet = lvwPets.SelectedItem as Pet;
            //Navigation.PushAsync(new Detail(pet));
        }
    }
}