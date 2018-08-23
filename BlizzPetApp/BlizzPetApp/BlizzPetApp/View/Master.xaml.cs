using BlizzPetApp.Models;
using BlizzPetApp.Repositories;
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
        public PetRepository _petRepo { get; set; }

        public List<Pet> _pets { get; set; }

        public int Family { get; set; }

		public Master ()
		{      
			InitializeComponent ();

            _petRepo = new PetRepository();
            GetPets();

            if (Family == 0)
            {
                lblFamily.Text = "Family 1";
            }
            else if (Family == 1)
            {
                lblFamily.Text = "Family 2";
            }
            else if (Family == 2)
            {
                lblFamily.Text = "Family 3";
            }
        }

        private async void GetPets()
        {
            _pets = await _petRepo.GetAllPets("flying");   
        }
        

        void lvwPets_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Pet pet = lvwPets.SelectedItem as Pet;
            //Navigation.PushAsync(new Detail(pet));
        }
    }
}