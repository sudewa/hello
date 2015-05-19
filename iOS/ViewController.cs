using System;
		
using UIKit;

namespace hello.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{		
		}


		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Code to start the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start ();
			#endif



		}

		public override void DidReceiveMemoryWarning ()
		{		
			base.DidReceiveMemoryWarning ();		
			// Release any cached data, images, etc that aren't in use.		
		}



		partial void btnConnect_TouchUpInside (UIButton sender)
		{
			txtWebText.Text = "Sudewa";
		}

		partial void btnReset_TouchUpInside (UIButton sender)
		{
			txtWebText.Text = "";
		}
	}
}
