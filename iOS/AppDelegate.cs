using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;

namespace HorseShow.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate :  global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		HSEventsManager hseventManager;


		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			// Code for starting up the Xamarin Test Cloud Agent
			#if ENABLE_TEST_CLOUD
			Xamarin.Calabash.Start();
			#endif

			App.ScreenWidth = UIScreen.MainScreen.Bounds.Width;
			App.ScreenHeight = UIScreen.MainScreen.Bounds.Height;

			#region Parse stuff
			hseventManager = new HSEventsManager(ParseStorage.Default);

			App.SetHSEventManager(hseventManager);

			#endregion

			LoadApplication (new App ());

			return base.FinishedLaunching (app, options);


		}
	}
}

