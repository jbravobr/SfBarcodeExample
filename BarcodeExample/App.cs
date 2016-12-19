using System;
using BarcodeExample.Views;
using Prism.Unity;

using Xamarin.Forms;

namespace BarcodeExample
{
	public class App : PrismApplication
	{
		protected override void OnInitialized()
		{
			NavigationService.NavigateAsync("HomePage");
		}

		protected override void RegisterTypes()
		{
			Container.RegisterTypeForNavigation<HomePage>();
		}
	}
}