using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ElevatorSample.Controls;
using ElevatorSample.ViewModels;
using PubSub;
using Xamarin.Forms;

namespace ElevatorSample.Models
{
    public class ElevatorModel : BaseModel
    {
        public ElevatorPageViewModel ParentModel { get; set; }
        private ElevatorFloor _elevator10 = new ElevatorFloor(10);
        private ElevatorFloor _elevator9 = new ElevatorFloor(9);
        private ElevatorFloor _elevator8 = new ElevatorFloor(8);
        private ElevatorFloor _elevator7 = new ElevatorFloor(7);
        private ElevatorFloor _elevator6 = new ElevatorFloor(6);
        private ElevatorFloor _elevator5 = new ElevatorFloor(5);
        private ElevatorFloor _elevator4 = new ElevatorFloor(4);
        private ElevatorFloor _elevator3 = new ElevatorFloor(3);
        private ElevatorFloor _elevator2 = new ElevatorFloor(2);
        private ElevatorFloor _elevator1 = new ElevatorFloor(1);
        private string _noOfPeopleInElevator = "0";
        private List<ElevatorFloor> _elevatorFloors = new List<ElevatorFloor>();
        public int CurrentFloor { get; set; } = 1;

        public ElevatorFloor Elevator10
        {
            get { return _elevator10; }
            set
            {
                _elevator10 = value;
                OnPropertyChanged(nameof(Elevator10));
            }
        }

        public ElevatorFloor Elevator9
        {
            get { return _elevator9; }
            set
            {
                _elevator9 = value;

                OnPropertyChanged(nameof(Elevator9));
            }
        }

        public ElevatorFloor Elevator8
        {
            get { return _elevator8; }
            set
            {
                _elevator8 = value;

                OnPropertyChanged(nameof(Elevator8));
            }
        }

        public ElevatorFloor Elevator7
        {
            get { return _elevator7; }
            set
            {
                _elevator7 = value;

                OnPropertyChanged(nameof(Elevator7));
            }
        }

        public ElevatorFloor Elevator6
        {
            get { return _elevator6; }
            set
            {
                _elevator6 = value;

                OnPropertyChanged(nameof(Elevator6));
            }
        }

        public ElevatorFloor Elevator5
        {
            get { return _elevator5; }
            set
            {
                _elevator5 = value;

                OnPropertyChanged(nameof(Elevator5));
            }
        }

        public ElevatorFloor Elevator4
        {
            get { return _elevator4; }
            set
            {
                _elevator4 = value;

                OnPropertyChanged(nameof(Elevator4));
            }
        }

        public ElevatorFloor Elevator3
        {
            get { return _elevator3; }
            set
            {
                _elevator3 = value;

                OnPropertyChanged(nameof(Elevator3));
            }
        }

        public ElevatorFloor Elevator2
        {
            get { return _elevator2; }
            set
            {
                _elevator2 = value;

                OnPropertyChanged(nameof(Elevator2));
            }
        }

        public ElevatorFloor Elevator1
        {
            get { return _elevator1; }
            set
            {
                _elevator1 = value;

                OnPropertyChanged(nameof(Elevator1));
            }
        }

        public string NoOfPeopleInElevator
        {
            get { return _noOfPeopleInElevator; }
            set
            {
                _noOfPeopleInElevator = value;
                OnPropertyChanged(nameof(NoOfPeopleInElevator));
            }
        }

        public List<ElevatorFloor> ElevatorFloors
        {
            get { return _elevatorFloors; }
            set
            {
                _elevatorFloors = value;
                OnPropertyChanged(nameof(ElevatorFloors));
            }
        }

        public List<FloorsToGo> FloorsToGo { get; set; }

        public ElevatorModel(string elevatorName, ElevatorPageViewModel parentModel)
        {
            AssignAllFloors();
            ParentModel = parentModel;
            FloorsToGo = new List<FloorsToGo>();

            this.Subscribe<FloorsToGo>(async (c) =>
            {
                FloorsToGo.Add(c);
                foreach (var floorsToGo in FloorsToGo)
                {
                    await Elevate(floorsToGo).ContinueWith((cc) =>
                    {
                        if (!cc.IsCompleted) return;
                        FloorsToGo.Remove(floorsToGo);
                        if (FloorsToGo.Count == 0)
                        {
                            CurrentFloor = Convert.ToInt32(floorsToGo.FloorNumber);
                        }
                    });
                }
            });
        }

        private void AssignAllFloors()
        {
            ElevatorFloors.Add(Elevator10);
            ElevatorFloors.Add(Elevator9);
            ElevatorFloors.Add(Elevator8);
            ElevatorFloors.Add(Elevator7);
            ElevatorFloors.Add(Elevator6);
            ElevatorFloors.Add(Elevator5);
            ElevatorFloors.Add(Elevator4);
            ElevatorFloors.Add(Elevator3);
            ElevatorFloors.Add(Elevator2);
            ElevatorFloors.Add(Elevator1);
        }

        public async Task Elevate(FloorsToGo floorsToGo)
        {
            await Task.Run(async () =>
            {
                if (floorsToGo != null)
                {
                    var currentNoOfPplInElevator = Convert.ToInt32(floorsToGo.NoOfPeople);
                    int k = ElevatorFloors.Count;
                    for (int i = 1; i <= k; ++i)
                    {
                        var elevatorFloor = ElevatorFloors.FirstOrDefault(f => f.FloorNumber == i);
                        if (i > 1)
                        {
                            await Task.Delay(new TimeSpan(0, 0, 0, 1));
                            var elevatorFloor1 = ElevatorFloors.FirstOrDefault(f => f.FloorNumber == i - 1);
                            elevatorFloor1.ElevatorColor = Color.White;
                            elevatorFloor1.NoOfPpl = string.Empty;
                        }

                        
                        //var currentFloorModel = ParentModel.AllFloor.FirstOrDefault(f => f.FloorNumber == i);
                        if (floorsToGo.NoOfPeople > 0)
                        {
                            var totalPpl = floorsToGo.NoOfPeople;
                            for (int j = 1; j <= totalPpl; j++)
                            {
                                if (currentNoOfPplInElevator <= 20 && floorsToGo.FloorNumber == i.ToString())
                                {
                                    ++currentNoOfPplInElevator;

                                    floorsToGo.NoOfPeople--;
                                }
                                else
                                {
                                    break;
                                }
                            }

                            if (floorsToGo.FloorNumber == i.ToString())
                            {
                                break;
                            }
                        }

                        elevatorFloor.ElevatorColor = Color.Maroon;
                        elevatorFloor.NoOfPpl = elevatorFloor.FloorNumber == i
                            ? currentNoOfPplInElevator.ToString()
                            : string.Empty;


                        
                    }
                }
            });
        }
    }
}
