using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsuarioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MenuPage : ContentPage
	{
		private ListView listMenu;

		public ListView ListMenu { get { return listMenu; } }

		public MenuPage()
		{
			InitializeComponent();
			base.Title = "Menu";

			var listMenu = new List<Item>();

			listMenu.Add(new Item
			{
				Title = "Cadastro Usuário",
				TargetType = typeof(CadastroPage)
			});

			listMenu.Add(new Item
			{
				Title = "Exemplo Layout Page",
				TargetType = typeof(ExemploLayoutPage)
			});

			ListMenu.ItemsSource = listMenu;
		}
	}

	public class Item {
		public string Title { get; set; }
		public Type TargetType { get; set; }
	}
}