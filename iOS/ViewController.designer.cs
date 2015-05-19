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

namespace hello.iOS
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton Button { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnConnect { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnReset { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextView txtBigText { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtWebText { get; set; }

		[Action ("btnConnect_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnConnect_TouchUpInside (UIButton sender);

		[Action ("btnReset_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnReset_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnConnect != null) {
				btnConnect.Dispose ();
				btnConnect = null;
			}
			if (btnReset != null) {
				btnReset.Dispose ();
				btnReset = null;
			}
			if (txtBigText != null) {
				txtBigText.Dispose ();
				txtBigText = null;
			}
			if (txtWebText != null) {
				txtWebText.Dispose ();
				txtWebText = null;
			}
		}
	}
}
