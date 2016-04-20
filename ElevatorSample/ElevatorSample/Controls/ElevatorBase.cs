﻿using ElevatorSample.Models;
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
            floor10.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.Elevator10.ElevatorColor);
            floor10.SetBinding<ElevatorModel>(Label.TextProperty, v => v.Elevator10.NoOfPpl);
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
            floor9.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.Elevator9.ElevatorColor);
            floor9.SetBinding<ElevatorModel>(Label.TextProperty, v => v.Elevator9.NoOfPpl);
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
            floor8.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.Elevator8.ElevatorColor);
            floor8.SetBinding<ElevatorModel>(Label.TextProperty, v => v.Elevator8.NoOfPpl);
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
            floor7.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.Elevator7.ElevatorColor);
            floor7.SetBinding<ElevatorModel>(Label.TextProperty, v => v.Elevator7.NoOfPpl);
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
            floor6.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.Elevator6.ElevatorColor);
            floor6.SetBinding<ElevatorModel>(Label.TextProperty, v => v.Elevator6.NoOfPpl);
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
            floor5.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.Elevator5.ElevatorColor);
            floor5.SetBinding<ElevatorModel>(Label.TextProperty, v => v.Elevator5.NoOfPpl);
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
            floor4.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.Elevator4.ElevatorColor);
            floor4.SetBinding<ElevatorModel>(Label.TextProperty, v => v.Elevator4.NoOfPpl);
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
            floor3.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.Elevator3.ElevatorColor);
            floor3.SetBinding<ElevatorModel>(Label.TextProperty, v => v.Elevator3.NoOfPpl);
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
            floor2.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.Elevator2.ElevatorColor);
            floor2.SetBinding<ElevatorModel>(Label.TextProperty, v => v.Elevator2.NoOfPpl);
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
            floor1.SetBinding<ElevatorModel>(Label.BackgroundColorProperty, v => v.Elevator1.ElevatorColor);
            floor1.SetBinding<ElevatorModel>(Label.TextProperty, v => v.Elevator1.NoOfPpl);
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
