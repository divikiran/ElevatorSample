namespace ElevatorSample.Models
{
    public class FloorModel : BaseModel
    {
        public int FloorNumber
        {
            get { return _floorNumber; }
            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

        private int _noOfPeople;
        private int _floorNumber;

        public int NoOfPeople
        {
            get { return _noOfPeople; }
            set
            {
                _noOfPeople = value;
                OnPropertyChanged(nameof(NoOfPeople));
            }
        }
    }
}
