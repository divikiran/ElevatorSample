using ElevatorSample.Models;
using Xamarin.Forms;

namespace ElevatorSample.Controls
{
    public class ElevatorFloor : BaseModel
    {
        private Color _elevatorColor = Color.White;
        private int _floorNumber;
        private string _noOfPpl;

        public Color ElevatorColor
        {
            get { return _elevatorColor; }
            set
            {
                _elevatorColor = value;
                OnPropertyChanged(nameof(ElevatorColor));
            }
        }

        public int FloorNumber
        {
            get { return _floorNumber; }
            set
            {
                _floorNumber = value;
                OnPropertyChanged(nameof(FloorNumber));
            }
        }

        public string NoOfPpl
        {
            get { return _noOfPpl; }
            set
            {
                _noOfPpl = value;
                OnPropertyChanged(nameof(NoOfPpl));
            }
        }

        public ElevatorFloor(int floornumber)
        {
            FloorNumber = floornumber;
        }
    }
}
