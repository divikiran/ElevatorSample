using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ElevatorSample.ViewModels;
using Xamarin.Forms;

namespace ElevatorSample.Models
{
    public class ElevatorModel : BaseModel
    {
        public ElevatorPageViewModel ParentModel { get; set; }
        private Color _elevatorColor10 = Color.White;
        private Color _elevatorColor9 = Color.White;
        private Color _elevatorColor8 = Color.White;
        private Color _elevatorColor7 = Color.White;
        private Color _elevatorColor6 = Color.White;
        private Color _elevatorColor5 = Color.White;
        private Color _elevatorColor4 = Color.White;
        private Color _elevatorColor3 = Color.White;
        private Color _elevatorColor2 = Color.White;
        private Color _elevatorColor1 = Color.White;
        private string _noOfPeopleInElevator = "0";
        public int CurrentFloor { get; set; } = 1;

        public List<int> FloorsToGo { get; set; }

        public Color ElevatorColor10
        {
            get { return _elevatorColor10; }
            set
            {
                _elevatorColor10 = value; 
                OnPropertyChanged(nameof(ElevatorColor10));
            }
        }

        public Color ElevatorColor9
        {
            get { return _elevatorColor9; }
            set
            {
                _elevatorColor9 = value;

                OnPropertyChanged(nameof(ElevatorColor9));
            }
        }

        public Color ElevatorColor8
        {
            get { return _elevatorColor8; }
            set
            {
                _elevatorColor8 = value;

                OnPropertyChanged(nameof(ElevatorColor8));
            }
        }

        public Color ElevatorColor7
        {
            get { return _elevatorColor7; }
            set
            {
                _elevatorColor7 = value;

                OnPropertyChanged(nameof(ElevatorColor7));
            }
        }

        public Color ElevatorColor6
        {
            get { return _elevatorColor6; }
            set
            {
                _elevatorColor6 = value;

                OnPropertyChanged(nameof(ElevatorColor6));
            }
        }

        public Color ElevatorColor5
        {
            get { return _elevatorColor5; }
            set
            {
                _elevatorColor5 = value;

                OnPropertyChanged(nameof(ElevatorColor5));
            }
        }

        public Color ElevatorColor4
        {
            get { return _elevatorColor4; }
            set
            {
                _elevatorColor4 = value;

                OnPropertyChanged(nameof(ElevatorColor4));
            }
        }

        public Color ElevatorColor3
        {
            get { return _elevatorColor3; }
            set
            {
                _elevatorColor3 = value;

                OnPropertyChanged(nameof(ElevatorColor3));
            }
        }

        public Color ElevatorColor2
        {
            get { return _elevatorColor2; }
            set
            {
                _elevatorColor2 = value;

                OnPropertyChanged(nameof(ElevatorColor2));
            }
        }

        public Color ElevatorColor1
        {
            get { return _elevatorColor1; }
            set
            {
                _elevatorColor1 = value;

                OnPropertyChanged(nameof(ElevatorColor1));
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

        public ElevatorModel(string elevatorName, ElevatorPageViewModel parentModel)
        {
            ParentModel = parentModel;
            FloorsToGo = new List<int>();
            FloorsToGo.Add(1);
            LabelTapped = new Command(ShowFloorsToSelect);
            Task.Run(async () =>
            {
                await Elevate();
            });
        }

        private void ShowFloorsToSelect(object obj)
        {
            ActionSheetConfig asc = new ActionSheetConfig().SetTitle("Select Floor");
            asc.Add("10", () =>
            {
                FloorToGo(10);
            });//, FloorToGo(10));
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
            var floorStatus = ParentModel.FloorOne;
            while (FloorsToGo.Count > 0)
            {
                int k = 10;
                
                for (int i = CurrentFloor; i <= k; i++)
                {
                    await Task.Delay(new TimeSpan(0, 0, 0, 2));
                    ElevatorColor1 = i == 1 ? Color.Maroon : Color.White;
                    ElevatorColor2 = i == 2 ? Color.Maroon : Color.White;
                    ElevatorColor3 = i == 3 ? Color.Maroon : Color.White;
                    ElevatorColor4 = i == 4 ? Color.Maroon : Color.White;
                    ElevatorColor5 = i == 5 ? Color.Maroon : Color.White;
                    ElevatorColor6 = i == 6 ? Color.Maroon : Color.White;
                    ElevatorColor7 = i == 7 ? Color.Maroon : Color.White;
                    ElevatorColor8 = i == 8 ? Color.Maroon : Color.White;
                    ElevatorColor9 = i == 9 ? Color.Maroon : Color.White;
                    ElevatorColor10 = i == 10 ? Color.Maroon : Color.White;

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
                            for (int j = 1; j < floorStatus.NoOfPeople; j++)
                            {
                                var currentNoOfPplInElevator = Convert.ToInt32(this.NoOfPeopleInElevator);
                                if (currentNoOfPplInElevator <= 20)
                                {
                                    currentNoOfPplInElevator ++;
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
                }
            }
        }
    }
}
