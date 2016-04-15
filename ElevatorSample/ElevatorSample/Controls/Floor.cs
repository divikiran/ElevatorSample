using System;
using Xamarin.Forms;
using System.Diagnostics;

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
			this.VerticalOptions = LayoutOptions.Start;
			this.HorizontalOptions = LayoutOptions.Start;

			this.Children.Add 
			(
				new Label () {
					Text = FloorNumber.ToString (),
					TextColor = Color.White,
					BackgroundColor = Color.Blue,
					HeightRequest = 30,
					WidthRequest = 30, 
					XAlign = TextAlignment.Center,
					YAlign = TextAlignment.Center
				});

			var button = new Button ();
			button.Clicked += async (object sender, EventArgs e) =>{
				
			};

			this.Children.Add (
				button
			);
		}
	}
}

