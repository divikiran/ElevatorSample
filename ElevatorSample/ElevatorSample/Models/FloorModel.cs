using System.Collections.Generic;
using System.Windows.Input;
using Acr.UserDialogs;
using ElevatorSample.Controls;
using PubSub;
using Xamarin.Forms;

namespace ElevatorSample.Models
{
    public class FloorModel : BaseModel
    {
        public ICommand LabelTapped { get; set; }
        public FloorModel(int floorNumber)
        {
            FloorNumber = floorNumber;
            LabelTapped = new Command(ShowFloorsToSelect);
            FloorsToGo = new List<FloorsToGo>();
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
        private int _noOfPeople;
        private int _floorNumber;
        private List<FloorsToGo> _floorsToGo;

        public int NoOfPeople
        {
            get { return _noOfPeople; }
            set
            {
                _noOfPeople = value;
                OnPropertyChanged(nameof(NoOfPeople));
            }
        }

        public void ShowFloorsToSelect(object obj)
        {
            ActionSheetConfig asc = new ActionSheetConfig().SetTitle("Select Floor");

            asc.Add("10", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorSelected = "10",
                    PplFromFloor = FloorNumber,
                    BoardOnFloor = new FloorModel(10) { NoOfPeople = NoOfPeople }
                });
            });
            asc.Add("9", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorSelected = "9",
                    PplFromFloor = FloorNumber,
                    BoardOnFloor = new FloorModel(9) { NoOfPeople = NoOfPeople }
                });
            });
            asc.Add("8", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorSelected = "8",
                    PplFromFloor = FloorNumber,
                    BoardOnFloor = new FloorModel(8) { NoOfPeople = NoOfPeople }
                });
            });
            asc.Add("7", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorSelected = "7",
                    PplFromFloor = FloorNumber,
                    BoardOnFloor = new FloorModel(7) { NoOfPeople = NoOfPeople }
                });
            });
            asc.Add("6", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorSelected = "6",
                    PplFromFloor = FloorNumber,
                    BoardOnFloor = new FloorModel(6) { NoOfPeople = NoOfPeople }
                });
            });
            asc.Add("5", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorSelected = "5",
                    PplFromFloor = FloorNumber,
                    BoardOnFloor = new FloorModel(5) { NoOfPeople = NoOfPeople }
                });
            });
            asc.Add("4", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorSelected = "4",
                    PplFromFloor = FloorNumber,
                    BoardOnFloor = new FloorModel(4) { NoOfPeople = NoOfPeople }
                });
            });
            asc.Add("3", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorSelected = "3",
                    PplFromFloor = FloorNumber,
                    BoardOnFloor = new FloorModel(3) { NoOfPeople = NoOfPeople }
                });
            });
            asc.Add("2", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorSelected = "2",
                    PplFromFloor = FloorNumber,
                    BoardOnFloor = new FloorModel(2) { NoOfPeople = NoOfPeople }
                });
            });
            asc.Add("1", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorSelected = "1",
                    PplFromFloor = FloorNumber,
                    BoardOnFloor = new FloorModel(1) { NoOfPeople = NoOfPeople}
                });
            });
            asc.SetCancel("Cancel");
            UserDialogs.Instance.ActionSheet(asc);
        }

        public List<FloorsToGo> FloorsToGo
        {
            get { return _floorsToGo; }
            set
            {
                _floorsToGo = value;
                OnPropertyChanged(nameof(FloorsToGo));
            }
        }

        public void FloorToGo(FloorsToGo floorToGo)
        {
            floorToGo.BoardOnFloor = this;
            FloorsToGo.Add(floorToGo);
            this.Publish<FloorsToGo>(floorToGo);
        }
    }
}
