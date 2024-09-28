using Foundation;
using UIKit;

namespace EditText
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the
	// User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
	[Register ("AppDelegate")]
	public class AppDelegate : UIApplicationDelegate
	{
		// class-level declarations

		UIWindow window;

		public override bool FinishedLaunching (UIApplication application, NSDictionary launchOptions)
		{
			// Override point for customization after application launch.
			// If not required for your application you can safely delete this method
			window=new UIWindow(UIScreen.MainScreen.Bounds);
			window.RootViewController=new ViewController();
			window.MakeKeyAndVisible ();
			return true;
		}


	}
}


