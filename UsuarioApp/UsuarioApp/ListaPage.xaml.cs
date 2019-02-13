using System;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsuarioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListaPage : ContentPage
	{
		public ListaPage()
		{
			InitializeComponent();
		}

		private async void LstUsuario_ItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as Usuario;

			if (item != null)
			{
				var cadastroPage = new CadastroPage();
				cadastroPage.PreencherCampos(item);

				await Navigation.PushAsync(cadastroPage);
			}
		}

		private async void BtnNovo_Clicked(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new CadastroPage());
		}

		protected override void OnAppearing()
		{
			using (var acessoDados = new AcessoDados<Usuario>())
			{
				lstUsuario.ItemsSource = acessoDados.Listar();
			}
		}
	}
}