using ElevatorSample.Controls;
using ElevatorSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ElevatorSample.ViewModels
{
    public class ElevatorPageViewModel: BaseModel
    {
        private ElevatorModel _elevatorModelA;
        private ElevatorModel _elevatorModelB;
        private ElevatorModel _elevatorModelC;
        private ElevatorModel _elevatorModelD;
        private string _title;
        private int _noOfPeople;
        private FloorModel _floorOne = new FloorModel();
        private FloorModel _floorTwo = new FloorModel();
        private FloorModel _floorThree = new FloorModel();
        private FloorModel _floorFour = new FloorModel();
        private FloorModel _floorFive = new FloorModel();
        private FloorModel _floorSix = new FloorModel();
        private FloorModel _floorSeven = new FloorModel();
        private FloorModel _floorEight = new FloorModel();
        private FloorModel _floorNine = new FloorModel();
        private FloorModel _floorTen = new FloorModel();

        public ElevatorModel ElevatorModelA
        {
            get { return _elevatorModelA; }
            set
            {
                _elevatorModelA = value;
                OnPropertyChanged(nameof(ElevatorModelA));
            }
        }

        public ElevatorModel ElevatorModelB
        {
            get { return _elevatorModelB; }
            set
            {
                _elevatorModelB = value;
                OnPropertyChanged(nameof(ElevatorModelB));
            }
        }

        public ElevatorModel ElevatorModelC
        {
            get { return _elevatorModelC; }
            set
            {
                _elevatorModelC = value;
                OnPropertyChanged(nameof(ElevatorModelC));
            }
        }

        public ElevatorModel ElevatorModelD
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

        public ElevatorPageViewModel()
        {
            _elevatorModelD = new ElevatorModel("ElevatorD", this);
            _elevatorModelC = new ElevatorModel("ElevatorC", this);
            _elevatorModelB = new ElevatorModel("ElevatorB",this);
            _elevatorModelA = new ElevatorModel("ElevatorA", this);
        
            _floorOne.FloorNumber = 1;
            _floorTwo.FloorNumber = 2;
            _floorThree.FloorNumber = 3;
            _floorFour.FloorNumber = 4;
            _floorFive.FloorNumber = 5;
            _floorSix.FloorNumber = 6;
            _floorEight.FloorNumber = 7;
            _floorEight.FloorNumber = 8;
            _floorNine.FloorNumber = 9;
            _floorTen.FloorNumber = 10;
        }
    }
}
