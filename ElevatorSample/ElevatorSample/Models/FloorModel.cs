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
        public FloorModel()
        {
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
                    FloorNumber = "10",
                });
            });
            asc.Add("9", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorNumber = "9",
                });
            });
            asc.Add("8", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorNumber = "8",
                });
            });
            asc.Add("7", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorNumber = "7",
                });
            });
            asc.Add("6", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorNumber = "6",
                });
            });
            asc.Add("5", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorNumber = "5",
                });
            });
            asc.Add("4", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorNumber = "4",
                });
            });
            asc.Add("3", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorNumber = "3",
                });
            });
            asc.Add("2", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorNumber = "2",
                });
            });
            asc.Add("1", () =>
            {
                FloorToGo(new FloorsToGo()
                {
                    NoOfPeople = NoOfPeople,
                    FloorNumber = "1",
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
            FloorsToGo.Add(floorToGo);

            this.Publish<FloorsToGo>(floorToGo);
        }
    }
}
