using XamarinBoilerplate.Droid.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamarinBoilerplate.Core.Controls;
using Color = Android.Graphics.Color;

[assembly: ExportRenderer(typeof(CustomRendererSampleLabel), typeof(CustomRendererSampleLabelRenderer))]
namespace XamarinBoilerplate.Droid.Renderers
{
    public class CustomRendererSampleLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null && e.OldElement == null) // Indicates that the item has been created.
            {
                // Construction Logic
                Control.SetPadding(25, 25, 25, 25);
                Control.SetBackgroundColor(Color.DarkCyan);
                Control.SetTextColor(Color.Wheat);
                Control.SetAllCaps(true);
                Control.Rotation = 5.0f;
                Control.ContentDescription = "This is the screen reader text. You didn't forget about the visually impaired, I trust?";
            }else if (e.NewElement == null && e.OldElement != null) // Indicates that the item has been destroyed.
            {
                // Deconstruction Logic
            }
        }
    }
}