using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using BlizzPetApp.View;
using BlizzPetApp.Repositories;
using BlizzPetApp.Models;

namespace BlizzPetApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Master : ContentPage
    {

        public PetRepository _petRepo { get; set; }

        public List<Pet> _pets { get; set; }

        public string Family
        {
            get { return this.lblFamily.Text; }
            set { this.lblFamily.Text = value; }
        }

        public Master()
        {
            InitializeComponent();

            _petRepo = new PetRepository();
            GetPets();

        }

        private async void GetPets()
        {
            string family = lblFamily.Text;
            _pets = await _petRepo.GetAllPets(family.ToLower());
            lvwPets.ItemsSource = _pets;
        }

        void lvwPets_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Pet pet = lvwPets.SelectedItem as Pet;
            //Navigation.PushAsync(new Detail(pet));
        }
    }
}