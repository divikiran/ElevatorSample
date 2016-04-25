using ElevatorSample.Controls;
using ElevatorSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Acr.UserDialogs;
using ElevatorSample.Enum;
using PubSub;
using Xamarin.Forms;

namespace ElevatorSample.ViewModels
{
    public class ElevatorPageViewModel : BaseModel
    {
        private ElevatorAModel _elevatorModelA;
        private ElevatorBModel _elevatorModelB;
        private ElevatorCModel _elevatorModelC;
        private ElevatorDModel _elevatorModelD;
        private string _title;
        private FloorModel _floorOne = new FloorModel(1);
        private FloorModel _floorTwo = new FloorModel(2);
        private FloorModel _floorThree = new FloorModel(3);
        private FloorModel _floorFour = new FloorModel(4);
        private FloorModel _floorFive = new FloorModel(5);
        private FloorModel _floorSix = new FloorModel(6);
        private FloorModel _floorSeven = new FloorModel(7);
        private FloorModel _floorEight = new FloorModel(8);
        private FloorModel _floorNine = new FloorModel(9);
        private FloorModel _floorTen = new FloorModel(10);
        private List<ElevatorModel> _allElevators = new List<ElevatorModel>();
        private List<FloorModel> _allFloor = new List<FloorModel>();


        public ElevatorAModel ElevatorModelA
        {
            get { return _elevatorModelA; }
            set
            {
                _elevatorModelA = value;
                OnPropertyChanged(nameof(ElevatorModelA));
            }
        }

        public ElevatorBModel ElevatorModelB
        {
            get { return _elevatorModelB; }
            set
            {
                _elevatorModelB = value;
                OnPropertyChanged(nameof(ElevatorModelB));
            }
        }

        public ElevatorCModel ElevatorModelC
        {
            get { return _elevatorModelC; }
            set
            {
                _elevatorModelC = value;
                OnPropertyChanged(nameof(ElevatorModelC));
            }
        }

        public ElevatorDModel ElevatorModelD
        {
            get { return _elevatorModelD; }
            set
            {
                _elevatorModelD = value;
                OnPropertyChanged(nameof(ElevatorModelD));
            }
        }

        public string Title
        {
            get { return _title; }
            set
            {
                _title = value;
                OnPropertyChanged(nameof(Title));
            }
        }

        public FloorModel FloorOne
        {
            get { return _floorOne; }
            set
            {
                _floorOne = value;
                OnPropertyChanged(nameof(FloorOne));
            }
        }

        public FloorModel FloorTwo
        {
            get { return _floorTwo; }
            set
            {
                _floorTwo = value;
                OnPropertyChanged(nameof(FloorTwo));
            }
        }

        public FloorModel FloorThree
        {
            get { return _floorThree; }
            set
            {
                _floorThree = value;
                OnPropertyChanged(nameof(FloorThree));
            }
        }

        public FloorModel FloorFour
        {
            get { return _floorFour; }
            set
            {
                _floorFour = value;
                OnPropertyChanged(nameof(FloorFour));
            }
        }

        public FloorModel FloorFive
        {
            get { return _floorFive; }
            set
            {
                _floorFive = value;
                OnPropertyChanged(nameof(FloorFive));
            }

        }

        public FloorModel FloorSix
        {
            get { return _floorSix; }
            set
            {
                _floorSix = value;
                OnPropertyChanged(nameof(FloorSix));
            }
        }

        public FloorModel FloorSeven
        {
            get { return _floorSeven; }
            set
            {
                _floorSeven = value;
                OnPropertyChanged(nameof(FloorSeven));
            }
        }

        public FloorModel FloorEight
        {
            get { return _floorEight; }
            set
            {
                _floorEight = value;
                OnPropertyChanged(nameof(FloorEight));
            }
        }

        public FloorModel FloorNine
        {
            get { return _floorNine; }
            set
            {
                _floorNine = value;
                OnPropertyChanged(nameof(FloorNine));
            }
        }

        public FloorModel FloorTen
        {
            get { return _floorTen; }
            set
            {
                _floorTen = value;
                OnPropertyChanged(nameof(FloorTen));
            }
        }

        public List<FloorModel> AllFloor
        {
            get { return _allFloor; }
            set
            {
                _allFloor = value;
                OnPropertyChanged(nameof(AllFloor));
            }
        }

        public List<ElevatorModel> AllElevators
        {
            get { return _allElevators; }
            set
            {
                _allElevators = value;
                OnPropertyChanged(nameof(AllElevators));
            }
        }

        private void SetAllFloors()
        {
            _floorOne.FloorNumber = 1;
            _floorTwo.FloorNumber = 2;
            _floorThree.FloorNumber = 3;
            _floorFour.FloorNumber = 4;
            _floorFive.FloorNumber = 5;
            _floorSix.FloorNumber = 6;
            _floorSeven.FloorNumber = 7;
            _floorEight.FloorNumber = 8;
            _floorNine.FloorNumber = 9;
            _floorTen.FloorNumber = 10;

            AllFloor.Add(FloorOne);
            AllFloor.Add(FloorTwo);
            AllFloor.Add(FloorThree);
            AllFloor.Add(FloorFour);
            AllFloor.Add(FloorFive);
            AllFloor.Add(FloorSix);
            AllFloor.Add(FloorSeven);
            AllFloor.Add(FloorEight);
            AllFloor.Add(FloorNine);
            AllFloor.Add(FloorTen);
        }

        private void SetAllElevators()
        {

            ElevatorModelA = new ElevatorAModel();
            ElevatorModelB = new ElevatorBModel();
            ElevatorModelC = new ElevatorCModel();
            ElevatorModelD = new ElevatorDModel();

            AllElevators.Add(ElevatorModelA);
            AllElevators.Add(ElevatorModelB);
            AllElevators.Add(ElevatorModelC);
            AllElevators.Add(ElevatorModelD);
        }

        public ElevatorPageViewModel()
        {
            SetAllElevators();
            SetAllFloors();
            ElevatorController();
        }

        public void ElevatorController()
        {
            this.Subscribe<FloorsToGo>(async (floorParameter) =>
            {
                var selectedFloor = floorParameter;
                if (!string.IsNullOrWhiteSpace(selectedFloor.FloorSelected))
                {
                    var allStoppedElevators =
                        AllElevators.Where(w => w.ElevatorCurrentStatus == ElevatorCurrentStatus.Stopped).ToList();
                    List<int> elevatorsStoppedOnFloor = new List<int>();
                    foreach (var allStoppedElevator in allStoppedElevators)
                    {
                        elevatorsStoppedOnFloor.Add(allStoppedElevator.StoppedOnFloor);
                    }

                    int closestFloorNumber =
                        elevatorsStoppedOnFloor.Aggregate(
                            (x, y) =>
                                Math.Abs(x - selectedFloor.BoardOnFloor.FloorNumber) <
                                Math.Abs(y - selectedFloor.BoardOnFloor.FloorNumber)
                                    ? x
                                    : y);

                    var closestElevator = allStoppedElevators.FirstOrDefault(w => w.StoppedOnFloor == closestFloorNumber);

                    await closestElevator.Engine(selectedFloor);

                    //if (closestElevator.ElevatorCurrentStatus == ElevatorCurrentStatus.Stopped)
                    //{
                    //    if (closestElevator.StoppedOnFloor > Convert.ToInt32(selectedFloor.PplFromFloor))
                    //    {
                    //        await closestElevator.Desend(Convert.ToInt32(closestElevator.StoppedOnFloor), selectedFloor);
                    //    }

                    //    await closestElevator.Elevate(selectedFloor);
                    //}
                }
            });
        }
    }
}