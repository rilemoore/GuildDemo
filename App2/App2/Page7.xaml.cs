﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page7 : ContentPage
	{
		public Page7 ()
		{
			InitializeComponent ();
            this.BackgroundImage = "smallbackground.png";
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.Title.FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label));
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}