using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace UsuarioApp
{
    public class ExemploMasterDetailPage : MasterDetailPage
    {
		public ExemploMasterDetailPage()
		{
			var menuPage = new MenuPage();
			menuPage.ListMenu.ItemSelected += ListMenu_ItemSelected;
			base.Master = menuPage;
			base.Detail = new NavigationPage(new ExemploContentPage());
		}

		private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MenuPage.Item;
			if (item != null)
			{
				base.Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
				base.IsPresented = false;
			}
		}		
	}
}
