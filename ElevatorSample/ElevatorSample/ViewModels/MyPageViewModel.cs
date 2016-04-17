using ElevatorSample.Models;
using Xamarin.Forms;

namespace ElevatorSample.ViewModels
{
    public class MyPageViewModel : BaseModel
    {
        private Color _colorName = Color.Aqua;
        private string _name;

        public Color ColorName
        {
            get { return _colorName; }
            set
            {
                _colorName = value; 
                OnPropertyChanged(nameof(ColorName));
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value; 
                OnPropertyChanged(nameof(Name));
            }
        }

        public MyPageViewModel()
        {
            Name = "Divikiran Ravela";
            ColorName = Color.Fuchsia;
        }
    }
}
