using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580044A
{
	public partial class MyPage3 : ContentPage
	{
		public MyPage3()
		{
			InitializeComponent();
			backButoon.Clicked += BackButoon_Clicked;
		}

		void BackButoon_Clicked(object sender, EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}