using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ElevatorSample.Controls;
using ElevatorSample.Models;
using Xamarin.Forms;

namespace ElevatorSample.Renderers
{
    public class CustomLabel : Label
    {
        public static readonly BindableProperty CustomColorProperty = BindableProperty.Create<CustomLabel, Color>(
            p => p.ColorCustom, Color.Transparent, BindingMode.TwoWay);

        public Color ColorCustom {
            get { return (Color)GetValue(CustomColorProperty); }
            set { SetValue(CustomColorProperty, value); }
        }
    }
}
