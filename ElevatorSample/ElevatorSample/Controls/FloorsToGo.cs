using ElevatorSample.Models;

namespace ElevatorSample.Controls
{
    public class FloorsToGo : BaseModel
    {
        private int _noOfPeople;
        private string _floorSelected;
        private int _pplFromFloor;
        private FloorModel _boardOnFloor;

        public int NoOfPeople
        {
            get { return _noOfPeople; }
            set
            {
                _noOfPeople = value; 
                OnPropertyChanged(nameof(NoOfPeople));
            }
        }

        public string FloorSelected
        {
            get { return _floorSelected; }
            set
            {
                _floorSelected = value; 
                OnPropertyChanged(nameof(FloorSelected));
            }
        }

        public int PplFromFloor
        {
            get { return _pplFromFloor; }
            set
            {
                _pplFromFloor = value;
                OnPropertyChanged(nameof(PplFromFloor));
            }
        }

        public FloorModel BoardOnFloor
        {
            get { return _boardOnFloor; }
            set
            {
                _boardOnFloor = value;
                OnPropertyChanged(nameof(BoardOnFloor));
            }
        }
    }
}
