using System;
using System.Net;
using System.IO;
		
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


			var rxcui = "198440";
			var request = HttpWebRequest.Create(string.Format(@"http://rxnav.nlm.nih.gov/REST/RxTerms/rxcui/{0}/allinfo", rxcui));
			request.ContentType = "application/json";
			request.Method = "GET";

			using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
			{
				if (response.StatusCode != HttpStatusCode.OK)
					Console.Out.WriteLine("Error fetching data. Server returned status code: {0}", response.StatusCode);
				using (StreamReader reader = new StreamReader(response.GetResponseStream()))
				{
					var content = reader.ReadToEnd();
					if(string.IsNullOrWhiteSpace(content)) {
						txtWebText.Text = "Response contained empty body...";
					}
					else {
						txtWebText.Text = content;

						txtBigText.Text = content;
					}

					//Assert.NotNull(content);
				}
			}
		}

		partial void btnReset_TouchUpInside (UIButton sender)
		{
			txtWebText.Text = "";
		}
	}
}
