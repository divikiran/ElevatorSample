using System;
using Xamarin.Forms;

namespace ElevatorSample
{
	public class Floor : StackLayout
	{
		public int FloorNumber {
			get;
			set;
		}
		public Floor (int floorNumber)
		{
			FloorNumber = floorNumber;
			this.VerticalOptions = LayoutOptions.Center;
			this.HorizontalOptions = LayoutOptions.FillAndExpand;

			this.Children.Add 
			(
				new Label () {
					Text = FloorNumber.ToString (),
					TextColor = Color.White,
					BackgroundColor = Color.Blue,
					HeightRequest = 30,
					WidthRequest = 30,
					VerticalOptions = LayoutOptions.Center,
					HorizontalOptions = LayoutOptions.Center
				});
		}
	}
}

