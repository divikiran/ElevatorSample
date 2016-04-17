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
        private FloorModel _floorOne;
        private FloorModel _floorTwo;
        private FloorModel _floorThree;
        private FloorModel _floorFour;
        private FloorModel _floorFive;
        private FloorModel _floorSix;
        private FloorModel _floorSeven;
        private FloorModel _floorEight;
        private FloorModel _floorNine;
        private FloorModel _floorTen;

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
        }
    }
}
