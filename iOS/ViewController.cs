using System;
using System.Threading.Tasks;
using UIKit;
using XamarinBandApp;

namespace XamarinBandApp.iOS
{
	public partial class ViewController : UIViewController
	{

		public ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			if (BandHelper.MyBands.Count > 0)
			{
				bandName.Text = BandHelper.MyBands[0].Name;
			}
			else
			{
				bandName.Text = "No Bands available";
			}
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.		
		}

		partial void UIButton23_TouchUpInside(UIButton sender)
		{
			bool isBandConnected = BandHelper.ConnectToBand();
			if (isBandConnected)
			{
				connectionLabel.Text = "Connected";
			}
		}
	}
}
