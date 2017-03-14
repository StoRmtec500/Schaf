using Schaf.Views;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Schaf
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			SetMainPage();
		}

		public static void SetMainPage()
		{
			Current.MainPage = new TabbedPage
			{
				Children =
				{
					new NavigationPage(new ItemsPage())
					{
						Title = "Browse",
						Icon = Xamarin.Forms.Device.OnPlatform("tab_feed.png",null,null)
					},
					new NavigationPage(new AboutPage())
					{
						Title = "About",
						Icon = Xamarin.Forms.Device.OnPlatform("tab_about.png",null,null)
					},
				}
			};
		}
	}
}
