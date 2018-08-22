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

        public int Family { get; set; }

		public Master ()
		{
			InitializeComponent ();

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

        

        void lvwPets_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //Pet pet = lvwPets.SelectedItem as Pet;
            //Navigation.PushAsync(new Detail(pet));
        }
    }
}