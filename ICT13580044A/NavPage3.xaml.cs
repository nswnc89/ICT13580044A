using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580044A
{
	public partial class NavPage3 : ContentPage
	{
		public NavPage3()
		{
			InitializeComponent();
			backButoon.Clicked += BackButoon_Clicked;
			backToRootButton.Clicked += BackToRootButton_Clicked;
		}

		void BackButoon_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

		void BackToRootButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PopToRootAsync();
		}
	}
}