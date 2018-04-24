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
	public partial class MovePage : ContentPage
	{
		public MovePage (Profile.MoveList moveList)
		{
			InitializeComponent ();

            M_Name.Text = moveList.Name;
            //https://www.c-sharpcorner.com/article/xamarin-forms-video-player-app/
        }

        private void BackBT(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}