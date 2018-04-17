using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TekkenApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AppMainPage : ContentPage
	{
        List<Profile.Profile> Characters = new List<Profile.Profile>();

		public AppMainPage ()
		{
			InitializeComponent ();

            Characters.Add(new Profile.Profile() { Name = "Alisa Bosconovitch", FightingStyle = "High Mobility Combat using thrusters", Origin = "Russia", Source = "ImgResources/AlisaBosconovitch.png" });


            ListViewUser.ItemsSource = Characters;
        }
	}
}