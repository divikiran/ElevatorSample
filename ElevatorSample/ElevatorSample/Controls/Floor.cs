using ElevatorSample.Models;
using Xamarin.Forms;

namespace ElevatorSample
{
    public class Floor : StackLayout
    {
        public int FloorNumber
        {
            get;
            set;
        }
        public Floor(int floorNumber)
        {
            FloorNumber = floorNumber;
            this.HorizontalOptions = LayoutOptions.StartAndExpand;
            this.VerticalOptions = LayoutOptions.Start;
            this.Orientation = StackOrientation.Vertical;

            if (FloorNumber == 10)
            {
                var labelsStack = new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal
                };
                labelsStack.Children.Add(new Label()
                {
                    Text = "Floor",
                    FontSize = 12
                });
                labelsStack.Children.Add(new Label()
                {
                    Text = "No of People",
                    FontSize = 12,
                    
                });
                this.Children.Add(labelsStack);
            }

            var floorStack = new StackLayout() {
                Orientation = StackOrientation.Horizontal
            };
            var floorLabel = new Label()
            {
                Text = FloorNumber.ToString(),
                TextColor = Color.White,
                BackgroundColor = Color.Blue,
                HeightRequest = 30,
                WidthRequest = 30,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
                ClassId = "Floor" + FloorNumber.ToString(),
            };
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