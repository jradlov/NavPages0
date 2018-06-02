using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavPages0
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class IntroductionPage : ContentPage
	{
		public IntroductionPage ()
		{
			InitializeComponent ();
		}

        async private void BackBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }

        // add this function if want to disable Phone Back button
        /*protected override bool OnBackButtonPressed()
        {
            return true;                        // disables phone Back button
        }*/
    }
}