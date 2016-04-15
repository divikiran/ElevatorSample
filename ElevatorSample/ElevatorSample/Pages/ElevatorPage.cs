using System;

using Xamarin.Forms;
using System.Collections.Generic;

namespace ElevatorSample
{
	public class ElevatorPage : ContentPage
	{
		public ElevatorPage ()
		{
			Title = "Elevator";

			var contentStack = new StackLayout (){
				VerticalOptions=LayoutOptions.FillAndExpand,
				HorizontalOptions=LayoutOptions.FillAndExpand
			};

			List<Floor> floors = new List<Floor> ();
			for(int i = 10; i >=1; i--)
			{
				contentStack.Children.Add(new Floor(i));
			}


			Content = contentStack;
		}
	}
}


