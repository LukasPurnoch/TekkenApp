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
		public MovePage (int index)
		{
			InitializeComponent ();


        }

        private void BackBT(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}