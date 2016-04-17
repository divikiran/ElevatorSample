namespace ElevatorSample.Models
{
    public class FloorModel : BaseModel
    {
        private int _noOfPeople;

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
