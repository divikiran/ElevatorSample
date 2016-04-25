using Xamarin.Forms;
using System.Collections.Generic;
using ElevatorSample.Controls;
using ElevatorSample.ViewModels;

namespace ElevatorSample
{
    public class ElevatorPage : ContentPage
    {
        public ElevatorPageViewModel ViewModel { get; set; }

        public ElevatorPage()
        {
            Title = "Elevator";
            this.SetBinding<ElevatorPageViewModel>(ContentPage.TitleProperty, v => v.Title);
            ViewModel = new ElevatorPageViewModel();
            BindingContext = ViewModel;

            var contentStack = new StackLayout()
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                BackgroundColor = Color.Olive,
                Orientation = StackOrientation.Vertical
            };

            var groupStack = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
            };

            var floorStack = new StackLayout();

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
            floorStack.Children.Add(labelsStack);

            var floor = new Floor();
            floor.SetBinding<ElevatorPageViewModel>(Floor.BindingContextProperty, v => v.FloorTen);
            floorStack.Children.Add(floor);

            floor = new Floor();
            floor.SetBinding<ElevatorPageViewModel>(Floor.BindingContextProperty, v => v.FloorNine);
            floorStack.Children.Add(floor);

            floor = new Floor();
            floor.SetBinding<ElevatorPageViewModel>(Floor.BindingContextProperty, v => v.FloorEight);
            floorStack.Children.Add(floor);

            floor = new Floor();
            floor.SetBinding<ElevatorPageViewModel>(Floor.BindingContextProperty, v => v.FloorSeven);
            floorStack.Children.Add(floor);

            floor = new Floor();
            floor.SetBinding<ElevatorPageViewModel>(Floor.BindingContextProperty, v => v.FloorSix);
            floorStack.Children.Add(floor);
            
            floor = new Floor();
            floor.SetBinding<ElevatorPageViewModel>(Floor.BindingContextProperty, v => v.FloorFive);
            floorStack.Children.Add(floor);

            floor = new Floor();
            floor.SetBinding<ElevatorPageViewModel>(Floor.BindingContextProperty, v => v.FloorFour);
            floorStack.Children.Add(floor);

            floor = new Floor();
            floor.SetBinding<ElevatorPageViewModel>(Floor.BindingContextProperty, v => v.FloorThree);
            floorStack.Children.Add(floor);

            floor = new Floor();
            floor.SetBinding<ElevatorPageViewModel>(Floor.BindingContextProperty, v => v.FloorTwo);
            floorStack.Children.Add(floor);

            floor = new Floor();
            floor.SetBinding<ElevatorPageViewModel>(Floor.BindingContextProperty, v => v.FloorOne);
            floorStack.Children.Add(floor);
            
            groupStack.Children.Add(floorStack);

            var elevatorsStack = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal
            };

            var elevatorA = new ElevatorA("Elevator A");
            elevatorA.SetBinding<ElevatorPageViewModel>(ElevatorA.BindingContextProperty, v => v.ElevatorModelA);
            elevatorsStack.Children.Add(elevatorA);

            var elevatorB = new ElevatorB("Elevator B");
            elevatorB.SetBinding<ElevatorPageViewModel>(ElevatorB.BindingContextProperty, v => v.ElevatorModelB);
            elevatorsStack.Children.Add(elevatorB);

            var elevatorC = new ElevatorC("Elevator C");
            elevatorC.SetBinding<ElevatorPageViewModel>(ElevatorC.BindingContextProperty, v => v.ElevatorModelC);
            elevatorsStack.Children.Add(elevatorC);

            var elevatorD = new ElevatorD("Elevator D");
            elevatorD.SetBinding<ElevatorPageViewModel>(ElevatorD.BindingContextProperty, v => v.ElevatorModelD);
            elevatorsStack.Children.Add(elevatorD);
            
            groupStack.Children.Add(elevatorsStack);

            contentStack.Children.Add(groupStack);

            Content = new ScrollView()
            {
                Content =
                    contentStack
            };
        }
    }
}


