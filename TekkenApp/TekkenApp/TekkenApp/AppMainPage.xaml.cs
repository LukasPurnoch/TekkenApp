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

            Characters.Add(new Profile.Profile() { Name = "Alisa Bosconovitch", FightingStyle = "High Mobility Combat", Origin = "Russia", Source = "ImgResources/AlisaBosconovitch.png" });
            Characters.Add(new Profile.Profile() { Name = "Asuka Kazama", FightingStyle = "Kazama Traditional Martial Art", Origin = "Japan", Source = "ImgResources/AsukaKazama.png" });
		    Characters.Add(new Profile.Profile() { Name = "'Bob' Robert Richards", FightingStyle = "Freestyle Karate", Origin = "USA", Source = "ImgResources/RobertRichards.png" });
		    Characters.Add(new Profile.Profile() { Name = "Bryan Fury", FightingStyle = "Kickbox", Origin = "USA", Source = "ImgResources/BryanFury.png" });
		    Characters.Add(new Profile.Profile() { Name = "Claudio Serafino", FightingStyle = "Sirius exorcism sorcery", Origin = "Italy", Source = "ImgResources/ClaudioSerafino.png" });
		    Characters.Add(new Profile.Profile() { Name = "Devil Jin", FightingStyle = "Unknown", Origin = "Unknown", Source = "ImgResources/DevilJin.png" });
		    Characters.Add(new Profile.Profile() { Name = "Eddy Gordo", FightingStyle = "Capoeira", Origin = "Brazil", Source = "ImgResources/EddyGordo.png" });
		    Characters.Add(new Profile.Profile() { Name = "Feng Wei", FightingStyle = "God Fist Martial Art", Origin = "China", Source = "ImgResources/FengWei.png" });
		    Characters.Add(new Profile.Profile() { Name = "Gigas", FightingStyle = "Destructive Impulse", Origin = "Data Deleted (Unknown)", Source = "ImgResources/Gigas.png" });
		    Characters.Add(new Profile.Profile() { Name = "Heihachi Mishima", FightingStyle = "Mishima Fighting Karate", Origin = "Japan", Source = "ImgResources/HeihachiMishima.png" });

            ListViewUser.ItemsSource = Characters;
        }
	}
}