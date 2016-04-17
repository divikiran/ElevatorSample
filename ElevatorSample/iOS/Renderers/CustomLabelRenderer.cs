using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using ElevatorSample.iOS.Renderers;
using ElevatorSample.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace ElevatorSample.iOS.Renderers
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            CustomLabel customLabel = (CustomLabel) this.Element;
            if (customLabel != null)
            {
                BackgroundColor = customLabel.ColorCustom.ToUIColor();
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            var customLabel = this.Element as CustomLabel;
            if (customLabel == null) return;
            //if (e.PropertyName == CustomLabel.CustomColorProperty.PropertyName)
            //{
            if (sender != null)
            {
                CustomLabel a = sender as CustomLabel;
                if (a != null)
                {
                    a.BackgroundColor = customLabel.ColorCustom;
                }
            }
            //}
        }
    }
}
