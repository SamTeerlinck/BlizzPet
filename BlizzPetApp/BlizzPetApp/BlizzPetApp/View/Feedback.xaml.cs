﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BlizzPetApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Feedback : ContentPage
	{
		public Feedback ()
		{
			InitializeComponent ();
		}

        private void btnSend_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}