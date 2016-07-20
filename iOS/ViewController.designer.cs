// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace XamarinBandApp.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bandLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel bandName { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton connectButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel connectionLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel stepCountLabel { get; set; }

        [Action ("UIButton23_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton23_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (bandLabel != null) {
                bandLabel.Dispose ();
                bandLabel = null;
            }

            if (bandName != null) {
                bandName.Dispose ();
                bandName = null;
            }

            if (connectButton != null) {
                connectButton.Dispose ();
                connectButton = null;
            }

            if (connectionLabel != null) {
                connectionLabel.Dispose ();
                connectionLabel = null;
            }

            if (stepCountLabel != null) {
                stepCountLabel.Dispose ();
                stepCountLabel = null;
            }
        }
    }
}