using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace NavPages0
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            // requirement when implementing Navigation
			MainPage = new NavigationPage(new WelcomePage()) {
                BackgroundColor = Color.LightSteelBlue,
                BarBackgroundColor = Color.DarkSlateBlue,
                BarTextColor = Color.White
            };
            
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
