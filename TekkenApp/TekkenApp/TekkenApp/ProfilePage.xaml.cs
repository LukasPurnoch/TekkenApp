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
	public partial class ProfilePage : ContentPage
	{
		public ProfilePage (Profile.Profile profile)
		{
			InitializeComponent ();

            Name.Text = profile.Name;
            FStyle.Text = profile.FightingStyle;
            Origin.Text = profile.Origin;

            Source.Source = profile.Source;

            BaseStory.Text = "Unlike most robots, Alisa possesses emotions and acts more like a human than a robot. She is a very kind-hearted individual who speaks in a polite manner and is sensitive to others' feelings. Alisa can also appear rather childish, resembling Ling Xiaoyu characteristically. In Tekken: Blood Vengeance, it is shown that she is also very capable of deception, as well as being quick to make friends with anyone, even Panda.";
            
		}
	}
}