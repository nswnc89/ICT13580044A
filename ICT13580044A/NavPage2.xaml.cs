using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580044A
{
	public partial class NavPage2 : ContentPage
	{
		public NavPage2()
		{
			InitializeComponent();
			nextButton.Clicked += NextButton_Clicked;
			backButoon.Clicked += BackButoon_Clicked;
		}

		void NextButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new NavPage3());
		}

		void BackButoon_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}
	}
}