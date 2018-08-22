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
		public Master (int family)
		{
			InitializeComponent ();

            if (family == 0)
            {
                Label1.Text = "You chose family 1";
            }
            if (family == 1)
            {
                Label1.Text = "You chose family 2";
            }
        }
	}
}