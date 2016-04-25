using System;
using ElevatorSample.Models;
using Xamarin.Forms;

namespace ElevatorSample.Controls
{
    public class ElevatorBase : StackLayout
    {
        public static readonly BindableProperty ElevatorModelProperty = BindableProperty.Create<ElevatorBase, ElevatorModel>(
            p => p.Elevator, null, BindingMode.TwoWay, null, ElevatorModelPropertyChanged);

        private static void ElevatorModelPropertyChanged(BindableObject bindable, ElevatorModel oldValue, ElevatorModel newValue)
        {
            var control = bindable as ElevatorBase;
            if (control != null)
            {
                if (newValue != null)
                {
                    control.BuildUi();
                }
            }
        }

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

        public Label Floor10 { get; set; }

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

            BuildUi();
        }

        private void BuildUi()
        {
            Floor10 = new Label
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center
            };

            Floor10.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorFloor10.ElevatorColor);
            Floor10.SetBinding<ElevatorModel>(Label.TextProperty, v => v.ElevatorFloor10.NoOfPpl);
            this.Children.Add(Floor10);

            var floor9 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor9.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorFloor9.ElevatorColor);
            floor9.SetBinding<ElevatorModel>(Label.TextProperty, v => v.ElevatorFloor9.NoOfPpl);
            this.Children.Add(floor9);

            var floor8 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor8.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorFloor8.ElevatorColor);
            floor8.SetBinding<ElevatorModel>(Label.TextProperty, v => v.ElevatorFloor8.NoOfPpl);
            this.Children.Add(floor8);

            var floor7 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor7.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorFloor7.ElevatorColor);
            floor7.SetBinding<ElevatorModel>(Label.TextProperty, v => v.ElevatorFloor7.NoOfPpl);
            this.Children.Add(floor7);

            var floor6 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor6.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorFloor6.ElevatorColor);
            floor6.SetBinding<ElevatorModel>(Label.TextProperty, v => v.ElevatorFloor6.NoOfPpl);
            this.Children.Add(floor6);

            var floor5 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor5.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorFloor5.ElevatorColor);
            floor5.SetBinding<ElevatorModel>(Label.TextProperty, v => v.ElevatorFloor5.NoOfPpl);
            this.Children.Add(floor5);

            var floor4 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor4.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorFloor4.ElevatorColor);
            floor4.SetBinding<ElevatorModel>(Label.TextProperty, v => v.ElevatorFloor4.NoOfPpl);
            this.Children.Add(floor4);

            var floor3 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor3.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorFloor3.ElevatorColor);
            floor3.SetBinding<ElevatorModel>(Label.TextProperty, v => v.ElevatorFloor3.NoOfPpl);
            this.Children.Add(floor3);

            var floor2 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor2.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorFloor2.ElevatorColor);
            floor2.SetBinding<ElevatorModel>(Label.TextProperty, v => v.ElevatorFloor2.NoOfPpl);
            this.Children.Add(floor2);

            var floor1 = new Label()
            {
                HeightRequest = 30,
                WidthRequest = 50,
                XAlign = TextAlignment.Center,
                YAlign = TextAlignment.Center,
            };
            floor1.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.ElevatorFloor1.ElevatorColor);
            floor1.SetBinding<ElevatorModel>(Label.TextProperty, v => v.ElevatorFloor1.NoOfPpl);
            this.Children.Add(floor1);
        }
    }
}