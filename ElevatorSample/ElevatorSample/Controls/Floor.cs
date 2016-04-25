using ElevatorSample.Models;
using Xamarin.Forms;

namespace ElevatorSample
{
    public class Floor : StackLayout
    {
        public FloorModel FloorModel { get; set; }
        public Floor()
        {
            this.HorizontalOptions = LayoutOptions.StartAndExpand;
            this.VerticalOptions = LayoutOptions.Start;
            this.Orientation = StackOrientation.Vertical;

            var floorStack = new StackLayout() {
                Orientation = StackOrientation.Horizontal
            };
            var floorLabel = new Label()
            {
                TextColor = Color.White,
                BackgroundColor = Color.Blue,
                HeightRequest = 30,
                WidthRequest = 30,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floorLabel.SetBinding<FloorModel>(Label.TextProperty, v => v.FloorNumber);
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.SetBinding<FloorModel>(TapGestureRecognizer.CommandProperty, v => v.LabelTapped);
            floorLabel.GestureRecognizers.Add(tap);
            floorStack.Children.Add(floorLabel);

            var noOfPeople = new Editor()
            {
                HorizontalOptions = LayoutOptions.Fill,
                Keyboard = Keyboard.Numeric,
                WidthRequest = 50,
                HeightRequest = 30,
            };
            noOfPeople.SetBinding<FloorModel>(Editor.TextProperty, v => v.NoOfPeople);
            floorStack.Children.Add(noOfPeople);

            this.Children.Add
            (
              floorStack
            );
        }
    }
}