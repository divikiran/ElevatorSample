using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ElevatorSample.Controls;
using ElevatorSample.Enum;
using ElevatorSample.ViewModels;
using PubSub;
using Xamarin.Forms;

namespace ElevatorSample.Models
{
    public class ElevatorModel : BaseModel
    {
        public ElevatorCurrentStatus ElevatorCurrentStatus { get; set; } = ElevatorCurrentStatus.Stopped;
        private ElevatorFloor _elevatorFloor10 = new ElevatorFloor(10);
        private ElevatorFloor _elevatorFloor9 = new ElevatorFloor(9);
        private ElevatorFloor _elevatorFloor8 = new ElevatorFloor(8);
        private ElevatorFloor _elevatorFloor7 = new ElevatorFloor(7);
        private ElevatorFloor _elevatorFloor6 = new ElevatorFloor(6);
        private ElevatorFloor _elevatorFloor5 = new ElevatorFloor(5);
        private ElevatorFloor _elevatorFloor4 = new ElevatorFloor(4);
        private ElevatorFloor _elevatorFloor3 = new ElevatorFloor(3);
        private ElevatorFloor _elevatorFloor2 = new ElevatorFloor(2);
        private ElevatorFloor _elevatorFloor1 = new ElevatorFloor(1);
        private string _noOfPeopleInElevator = "0";
        private List<ElevatorFloor> _elevatorFloors = new List<ElevatorFloor>();
        private int _stoppedOnFloor;


        public ElevatorFloor ElevatorFloor10
        {
            get { return _elevatorFloor10; }
            set
            {
                _elevatorFloor10 = value;
                OnPropertyChanged(nameof(ElevatorFloor10));
            }
        }

        public ElevatorFloor ElevatorFloor9
        {
            get { return _elevatorFloor9; }
            set
            {
                _elevatorFloor9 = value;
                OnPropertyChanged(nameof(ElevatorFloor9));
            }
        }

        public ElevatorFloor ElevatorFloor8
        {
            get { return _elevatorFloor8; }
            set
            {
                _elevatorFloor8 = value;
                OnPropertyChanged(nameof(ElevatorFloor8));
            }
        }

        public ElevatorFloor ElevatorFloor7
        {
            get { return _elevatorFloor7; }
            set
            {
                _elevatorFloor7 = value;
                OnPropertyChanged(nameof(ElevatorFloor7));
            }
        }

        public ElevatorFloor ElevatorFloor6
        {
            get { return _elevatorFloor6; }
            set
            {
                _elevatorFloor6 = value;
                OnPropertyChanged(nameof(ElevatorFloor6));
            }
        }

        public ElevatorFloor ElevatorFloor5
        {
            get { return _elevatorFloor5; }
            set
            {
                _elevatorFloor5 = value;
                OnPropertyChanged(nameof(ElevatorFloor5));
            }
        }

        public ElevatorFloor ElevatorFloor4
        {
            get { return _elevatorFloor4; }
            set
            {
                _elevatorFloor4 = value;
                OnPropertyChanged(nameof(ElevatorFloor4));
            }
        }

        public ElevatorFloor ElevatorFloor3
        {
            get { return _elevatorFloor3; }
            set
            {
                _elevatorFloor3 = value;
                OnPropertyChanged(nameof(ElevatorFloor3));
            }
        }

        public ElevatorFloor ElevatorFloor2
        {
            get { return _elevatorFloor2; }
            set
            {
                _elevatorFloor2 = value;
                OnPropertyChanged(nameof(ElevatorFloor2));
            }
        }

        public ElevatorFloor ElevatorFloor1
        {
            get { return _elevatorFloor1; }
            set
            {
                _elevatorFloor1 = value;
                OnPropertyChanged(nameof(ElevatorFloor1));
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

        public int StoppedOnFloor
        {
            get { return _stoppedOnFloor; }
            set
            {
                _stoppedOnFloor = value;
                OnPropertyChanged(nameof(StoppedOnFloor));
            }
        }

        public ElevatorModel()
        {
            StoppedOnFloor = 1;
            AssignAllFloors();
            Task.Run(async () =>
            {
                var floorsToGo = new FloorsToGo()
                {
                    FloorSelected = 1.ToString(),
                    BoardOnFloor = new FloorModel(1),
                    PplFromFloor = 1
                };
                await Engine(floorsToGo);
            });
        }

        private void AssignAllFloors()
        {
            ElevatorFloors.Add(ElevatorFloor10);
            ElevatorFloors.Add(ElevatorFloor9);
            ElevatorFloors.Add(ElevatorFloor8);
            ElevatorFloors.Add(ElevatorFloor7);
            ElevatorFloors.Add(ElevatorFloor6);
            ElevatorFloors.Add(ElevatorFloor5);
            ElevatorFloors.Add(ElevatorFloor4);
            ElevatorFloors.Add(ElevatorFloor3);
            ElevatorFloors.Add(ElevatorFloor2);
            ElevatorFloors.Add(ElevatorFloor1);
        }

        private bool ElevatorLogic(FloorsToGo floorsToGo, ElevatorFloor elevatorFloor, int i, int currentNoOfPplInElevator)
        {
            if (elevatorFloor.FloorNumber >= floorsToGo.PplFromFloor)
            {
                elevatorFloor.NoOfPpl = elevatorFloor.FloorNumber == i
                    ? currentNoOfPplInElevator.ToString()
                    : string.Empty;

                if (elevatorFloor?.FloorNumber == floorsToGo?.PplFromFloor && floorsToGo.BoardOnFloor != null)
                {
                    floorsToGo.BoardOnFloor.NoOfPeople = 0;
                }
            }

            elevatorFloor.ElevatorColor = Color.Maroon;
            if (floorsToGo.FloorSelected == i.ToString())
            {
                if (!string.IsNullOrWhiteSpace(elevatorFloor.NoOfPpl))
                {
                    StoppedOnFloor = i;
                    elevatorFloor.NoOfPpl = String.Empty;
                    ElevatorCurrentStatus = ElevatorCurrentStatus.Stopped;
                    return true;
                }
            }
            return false;
        }
        
        public async Task Elevate(FloorsToGo floorsToGo)
        {
            ElevatorCurrentStatus = ElevatorCurrentStatus.GoingUp;
            if (floorsToGo != null)
            {
                var currentNoOfPplInElevator = floorsToGo.NoOfPeople;
                int k = ElevatorFloors.Count;
                for (int i = StoppedOnFloor; i <= k; ++i)
                {
                    var elevatorFloor = await ColorTheFloor(i);
                    if (elevatorFloor.FloorNumber == floorsToGo.BoardOnFloor.FloorNumber)
                    {

                        elevatorFloor.NoOfPpl = currentNoOfPplInElevator.ToString();
                        if (Convert.ToInt32(floorsToGo.FloorSelected) > i)
                        {
                            StoppedOnFloor = i;
                            await ElevateToFloor(floorsToGo);
                            break;
                        }
                        else
                        {
                            StoppedOnFloor = i;
                            await DesendToFloor(floorsToGo);
                            break;
                        }
                    }
                }
            }
        }

        private async Task<ElevatorFloor> ColorTheFloor(int i)
        {
            var elevatorFloor = ElevatorFloors.FirstOrDefault(f => f.FloorNumber == i);
            if (i > 1)
            {
                await Task.Delay(new TimeSpan(0, 0, 0, 1));
                var elevatorFloor1 = ElevatorFloors.FirstOrDefault(f => f.FloorNumber == (i - 1));
                elevatorFloor1.ElevatorColor = Color.White;
                elevatorFloor1.NoOfPpl = string.Empty;
            }

            elevatorFloor.ElevatorColor = Color.Maroon;
            return elevatorFloor;
        }

        private async Task ElevateToFloor(FloorsToGo floorsToGo)
        {
            int k = ElevatorFloors.Count;
            floorsToGo.BoardOnFloor.NoOfPeople = 0;
            for (int i = StoppedOnFloor; i <= k; i++)
            {
                var elevatorFloor = await ColorTheFloor(i);
                elevatorFloor.NoOfPpl = floorsToGo.NoOfPeople.ToString();
                if (floorsToGo.FloorSelected == i.ToString())
                {
                    if (floorsToGo.NoOfPeople > 0)
                    {
                        StoppedOnFloor = i;
                        elevatorFloor.NoOfPpl = String.Empty;
                        ElevatorCurrentStatus = ElevatorCurrentStatus.Stopped;
                        break;
                    }
                }
            }
        }

        private async Task DesendToFloor(FloorsToGo floorsToGo)
        {
            var noOfPpl = floorsToGo.NoOfPeople.ToString();
            floorsToGo.BoardOnFloor.NoOfPeople = 0;
            for (int i = StoppedOnFloor; i >= 1; --i)
            {
                var elevatorFloor = await ColorTheFloorDesend(i);
                elevatorFloor.NoOfPpl = noOfPpl;
                if (floorsToGo.FloorSelected == i.ToString())
                {
                    if (floorsToGo.NoOfPeople > 0)
                    {
                        StoppedOnFloor = i;
                        elevatorFloor.NoOfPpl = String.Empty;
                        ElevatorCurrentStatus = ElevatorCurrentStatus.Stopped;
                        break;
                    }
                }
            }
        }

        private async Task<ElevatorFloor> ColorTheFloorDesend(int i)
        {
            await Task.Delay(new TimeSpan(0, 0, 0, 1));
            var elevatorFloor1 = ElevatorFloors.FirstOrDefault(f => f.FloorNumber == i + 1);
            elevatorFloor1.ElevatorColor = Color.White;
            elevatorFloor1.NoOfPpl = String.Empty;

            var elevatorFloor = ElevatorFloors.FirstOrDefault(f => f.FloorNumber == i);
            elevatorFloor.ElevatorColor = Color.Maroon;
            
            return elevatorFloor;
        }
        
        public async Task Desend(FloorsToGo floorsToGo)
        {
            int k = ElevatorFloors.Count;
            for (int i = StoppedOnFloor; i >= 1; --i)
            {
                var elevatorFloor = await ColorTheFloorDesend(i);
                if (elevatorFloor.FloorNumber == floorsToGo.BoardOnFloor.FloorNumber)
                {
                    elevatorFloor.NoOfPpl = floorsToGo.NoOfPeople.ToString();
                    if (Convert.ToInt32(floorsToGo.FloorSelected) > i)
                    {
                        StoppedOnFloor = i;
                        await ElevateToFloor(floorsToGo);
                        break;
                    }
                    else
                    {
                        StoppedOnFloor = i;
                        await DesendToFloor(floorsToGo);
                        break;
                    }
                }
                /*if (ElevatorLogic(selectedFloor, elevatorFloor, i, 0))
                {
                    break;
                }*/

                //if (await ElevateAndDecend(selectedFloor, elevatorFloor, i)) break;
            }
        }
        
        public async Task Engine(FloorsToGo selectedFloor)
        {
            if (StoppedOnFloor < selectedFloor.PplFromFloor)
            {
                await Elevate(selectedFloor);
            }
            else
            {
                await Desend(selectedFloor);
            }

            ElevatorCurrentStatus = ElevatorCurrentStatus.Stopped;
        }
    }
}