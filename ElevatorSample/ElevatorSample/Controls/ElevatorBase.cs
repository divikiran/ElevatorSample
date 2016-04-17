using ElevatorSample.Models;
using Xamarin.Forms;

namespace ElevatorSample.Controls
{
    public class ElevatorBase : StackLayout
    {

        public static readonly BindableProperty ElevatorModelProperty = BindableProperty.Create<ElevatorBase, ElevatorModel>(
            p => p.Elevator, null,BindingMode.TwoWay);

        public ElevatorModel Elevator
        {
            get
            {
                return (ElevatorModel)GetValue(ElevatorModelProperty);
            }
            set
            {
                SetValue(ElevatorModelProperty, value);
            }
        }

        public ElevatorBase(string elevatorName)
        {
            var labelsStack = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal
            };

            labelsStack.Children.Add(new Label()
            {
                Text = elevatorName,
                FontSize = 12
            });

            this.Children.Add(labelsStack);

            var floor10 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor10.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorColor10);
            floor10.SetBinding<ElevatorModel>(Label.TextProperty, v => v.NoOfPeopleInElevator);
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.SetBinding<ElevatorModel>(TapGestureRecognizer.CommandProperty,v => v.LabelTapped);
            floor10.GestureRecognizers.Add(tap);
            this.Children.Add(floor10);

            var floor9 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor9.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorColor9);
            floor9.SetBinding<ElevatorModel>(Label.TextProperty, v => v.NoOfPeopleInElevator);
            tap = new TapGestureRecognizer();
            tap.SetBinding<ElevatorModel>(TapGestureRecognizer.CommandProperty, v => v.LabelTapped);
            floor9.GestureRecognizers.Add(tap);
            this.Children.Add(floor9);

            var floor8 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor8.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorColor8);
            floor8.SetBinding<ElevatorModel>(Label.TextProperty, v => v.NoOfPeopleInElevator);
            tap = new TapGestureRecognizer();
            tap.SetBinding<ElevatorModel>(TapGestureRecognizer.CommandProperty, v => v.LabelTapped);
            floor8.GestureRecognizers.Add(tap);
            this.Children.Add(floor8);

            var floor7 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor7.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorColor7);
            floor7.SetBinding<ElevatorModel>(Label.TextProperty, v => v.NoOfPeopleInElevator);
            tap = new TapGestureRecognizer();
            tap.SetBinding<ElevatorModel>(TapGestureRecognizer.CommandProperty, v => v.LabelTapped);
            floor7.GestureRecognizers.Add(tap);
            this.Children.Add(floor7);

            var floor6 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor6.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorColor6);
            floor6.SetBinding<ElevatorModel>(Label.TextProperty, v => v.NoOfPeopleInElevator);
            tap = new TapGestureRecognizer();
            tap.SetBinding<ElevatorModel>(TapGestureRecognizer.CommandProperty, v => v.LabelTapped);
            floor6.GestureRecognizers.Add(tap);
            this.Children.Add(floor6);

            var floor5 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor5.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorColor5);
            floor5.SetBinding<ElevatorModel>(Label.TextProperty, v => v.NoOfPeopleInElevator);
            tap = new TapGestureRecognizer();
            tap.SetBinding<ElevatorModel>(TapGestureRecognizer.CommandProperty, v => v.LabelTapped);
            floor5.GestureRecognizers.Add(tap);
            this.Children.Add(floor5);

            var floor4 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor4.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorColor4);
            floor4.SetBinding<ElevatorModel>(Label.TextProperty, v => v.NoOfPeopleInElevator);
            tap = new TapGestureRecognizer();
            tap.SetBinding<ElevatorModel>(TapGestureRecognizer.CommandProperty, v => v.LabelTapped);
            floor4.GestureRecognizers.Add(tap);
            this.Children.Add(floor4);

            var floor3 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor3.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorColor3);
            floor3.SetBinding<ElevatorModel>(Label.TextProperty, v => v.NoOfPeopleInElevator);
            tap = new TapGestureRecognizer();
            tap.SetBinding<ElevatorModel>(TapGestureRecognizer.CommandProperty, v => v.LabelTapped);
            floor3.GestureRecognizers.Add(tap);
            this.Children.Add(floor3);

            var floor2 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor2.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorColor2);
            floor2.SetBinding<ElevatorModel>(Label.TextProperty, v => v.NoOfPeopleInElevator);
            tap = new TapGestureRecognizer();
            tap.SetBinding<ElevatorModel>(TapGestureRecognizer.CommandProperty, v => v.LabelTapped);
            floor2.GestureRecognizers.Add(tap);
            this.Children.Add(floor2);

            var floor1 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor1.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorColor1);
            floor1.SetBinding<ElevatorModel>(Label.TextProperty, v => v.NoOfPeopleInElevator);
            tap = new TapGestureRecognizer();
            tap.SetBinding<ElevatorModel>(TapGestureRecognizer.CommandProperty, v => v.LabelTapped);
            floor1.GestureRecognizers.Add(tap);
            this.Children.Add(floor1);
        }
    }
}

//for (int i = 10; i >= 1; i--)
//{
//    this.Children.Add(new Label()
//    {
//        Text = i.ToString(),
//        HeightRequest = 30,
//        WidthRequest = 50,
//        XAlign = TextAlignment.Center,
//        YAlign = TextAlignment.Center,
//        BackgroundColor = Color.White,
//        ClassId = elevatorName + i.ToString(),
//    });
//}
