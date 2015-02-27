using dotnetspain2015.CustomControls;
using dotnetspain2015.iOS.Controls;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(CustomEntry), typeof(CustomEntryRenderer))]
namespace dotnetspain2015.iOS.Controls
{
    class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {   // Perform initial setup
                // Do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.LightGray;
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}