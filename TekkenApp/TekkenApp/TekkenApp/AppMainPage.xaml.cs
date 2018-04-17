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
        List<string> test = new List<string>();

		public AppMainPage ()
		{
			InitializeComponent ();

            test.Add("test");
            ListViewUser.ItemsSource = test;
        }
	}
}