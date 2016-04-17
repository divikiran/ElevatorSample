using System;
using ElevatorSample.Converters;
using ElevatorSample.ViewModels;
using Xamarin.Forms;

namespace ElevatorSample
{
	public class MyPage : ContentPage
	{
	    public MyPageViewModel ViewModel { get; set; }
		public MyPage ()
		{
            ViewModel = new MyPageViewModel();
		    BindingContext = ViewModel;
		    var label = new Label()
		    {
		        Text =  "Test",
                HeightRequest = 30,
                WidthRequest = 30,
                BackgroundColor = Xamarin.Forms.Color.Green
		    };
            label.SetBinding<MyPageViewModel>(Label.BackgroundColorProperty, vv => vv.ColorName);
            label.SetBinding<MyPageViewModel>(Label.TextProperty, vv => vv.Name);

		    var stack = new StackLayout
		    {
		        BackgroundColor = Color.Red,
		        HeightRequest = 50,
		        WidthRequest = 50
		    };
		    stack.SetBinding<MyPageViewModel>(StackLayout.BackgroundColorProperty, v => v.ColorName, BindingMode.TwoWay);
		   
		    stack.Children.Add(label);


            Content = new StackLayout { 
				Children = {
                    stack
                }
			};
		}

	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
            ViewModel.ColorName = Color.Blue;
	        //ViewModel.Name = "Anahi";
	    }
	}
}


