using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ElevatorSample.Controls;
using ElevatorSample.ViewModels;
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

        public List<int> FloorsToGo { get; set; }

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

        public ICommand LabelTapped { get; set; }

        public List<ElevatorFloor> ElevatorFloors
        {
            get { return _elevatorFloors; }
            set
            {
                _elevatorFloors = value;
                OnPropertyChanged(nameof(ElevatorFloors));
            }
        }

        public ElevatorModel(string elevatorName, ElevatorPageViewModel parentModel)
        {
            AssignAllFloors();
            ParentModel = parentModel;
            FloorsToGo = new List<int> {1};
            LabelTapped = new Command(ShowFloorsToSelect);
            Task.Run(async () =>
            {
                await Elevate();
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

        private void ShowFloorsToSelect(object obj)
        {
            ActionSheetConfig asc = new ActionSheetConfig().SetTitle("Select Floor");

            asc.Add("10", () =>
            {
                FloorToGo(10);
            });
            asc.Add("9", () =>
            {
                FloorToGo(9);
            });
            asc.Add("8", () =>
            {
                FloorToGo(8);
            });
            asc.Add("7", () =>
            {
                FloorToGo(7);
            });
            asc.Add("6", () =>
            {
                FloorToGo(6);
            });
            asc.Add("5", () =>
            {
                FloorToGo(5);
            });
            asc.Add("4", () =>
            {
                FloorToGo(4);
            });
            asc.Add("3", () =>
            {
                FloorToGo(3);
            });
            asc.Add("2", () =>
            {
                FloorToGo(2);
            });
            asc.Add("1", () =>
            {
                FloorToGo(1);
            });
            asc.SetCancel("Cancel");
            UserDialogs.Instance.ActionSheet(asc);
        }

        private void FloorToGo(int i)
        {
            FloorsToGo.Add(i);
            Task.Run(async () =>
            {
                await Elevate();
            });
        }

        public async Task Elevate()
        {
            await Task.Run(async () =>
            {

                // var floorStatus = ParentModel.FloorOne;
                while (FloorsToGo.Count > 0)
                {
                    var currentNoOfPplInElevator = Convert.ToInt32(this.NoOfPeopleInElevator);
                    int k = ElevatorFloors.Count;
                    for (int i = 1; i <= k; ++i)
                    {
                        var allFloors = ElevatorFloors.OrderByDescending(o => o.FloorNumber);
                        var elevatorFloor = ElevatorFloors.FirstOrDefault(f => f.FloorNumber == i);
                        if (i > 1)
                        {
                            await Task.Delay(new TimeSpan(0, 0, 0, 1));
                            var elevatorFloor1 = ElevatorFloors.FirstOrDefault(f => f.FloorNumber == i - 1);
                            elevatorFloor1.ElevatorColor = Color.White;
                            elevatorFloor1.NoOfPpl = string.Empty;
                        }

                        /*foreach (var elevatorFloor in allFloors)
                        {*/
                        var currentFloorModel = ParentModel.AllFloor.FirstOrDefault(f => f.FloorNumber == i);
                            if (currentFloorModel.NoOfPeople > 0)
                            {
                                var totalPpl = currentFloorModel.NoOfPeople;
                                
                                    if (currentNoOfPplInElevator <= 20 && currentFloorModel.FloorNumber == i)
                                    {
                                        currentNoOfPplInElevator += totalPpl;

                                        currentFloorModel.NoOfPeople = 0;
                                    }
                                    else
                                    {
                                        break;
                                    }
                                
                            }

                            elevatorFloor.ElevatorColor =  Color.Maroon;
                            elevatorFloor.NoOfPpl = elevatorFloor.FloorNumber == i
                                ? currentNoOfPplInElevator.ToString()
                                : string.Empty;
                            //elevatorFloor.ElevatorColor = Color.Maroon;
                        /*}*/

                        if (FloorsToGo.Contains(i))
                        {
                            FloorsToGo.Remove(i);

                            if (FloorsToGo.Count == 0)
                            {
                                CurrentFloor = i;
                                break;
                            }
                        }
                    }


/*int k = 10;
                for (int i = CurrentFloor; i <= k; i++)
                {
                    await Task.Delay(new TimeSpan(0, 0, 0, 2));
                    Elevator1 = i == 1 ? Color.Maroon : Color.White;
                    Elevator2 = i == 2 ? Color.Maroon : Color.White;
                    Elevator3 = i == 3 ? Color.Maroon : Color.White;
                    Elevator4 = i == 4 ? Color.Maroon : Color.White;
                    Elevator5 = i == 5 ? Color.Maroon : Color.White;
                    Elevator6 = i == 6 ? Color.Maroon : Color.White;
                    Elevator7 = i == 7 ? Color.Maroon : Color.White;
                    Elevator8 = i == 8 ? Color.Maroon : Color.White;
                    Elevator9 = i == 9 ? Color.Maroon : Color.White;
                    Elevator10 = i == 10 ? Color.Maroon : Color.White;

                    switch (i)
                    {
                        case 1:
                            floorStatus = ParentModel.FloorOne;
                            break;
                        case 2:
                            floorStatus = ParentModel.FloorTwo;
                            break;
                        case 3:
                            floorStatus = ParentModel.FloorThree;
                            break;
                        case 4:
                            floorStatus = ParentModel.FloorFour;
                            break;
                        case 5:
                            floorStatus = ParentModel.FloorFive;
                            break;
                        case 6:
                            floorStatus = ParentModel.FloorSix;
                            break;
                        case 7:
                            floorStatus = ParentModel.FloorSeven;
                            break;
                        case 8:
                            floorStatus = ParentModel.FloorEight;
                            break;
                        case 9:
                            floorStatus = ParentModel.FloorNine;
                            break;
                        case 10:
                            floorStatus = ParentModel.FloorTen;
                            break;
                        default:
                            break;
                    }

                    if (floorStatus != null)
                    {
                        if (floorStatus.NoOfPeople > 0)
                        {
                            var totalPpl = floorStatus.NoOfPeople;
                            for (int j = 1; j <= totalPpl; j++)
                            {
                                var currentNoOfPplInElevator = Convert.ToInt32(this.NoOfPeopleInElevator);
                                if (currentNoOfPplInElevator <= 20)
                                {
                                    currentNoOfPplInElevator++;
                                    this.NoOfPeopleInElevator = currentNoOfPplInElevator.ToString();
                                    floorStatus.NoOfPeople--;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                    }

                    if (FloorsToGo.Contains(i))
                    {
                        FloorsToGo.Remove(i);

                        if (FloorsToGo.Count == 0)
                        {
                            CurrentFloor = i;

                            break;
                        }
                    }
                }*/
                }
            });
        }

    }
}
