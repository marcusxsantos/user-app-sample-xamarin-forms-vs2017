using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ModernHttpClient;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UsuarioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ExemploHttpPage : ContentPage
	{
		public ExemploHttpPage ()
		{
			InitializeComponent ();
		}

		public async void BtnRequisicao_Clicked(object sender, EventArgs e)
		{
			try
			{
				var url = "http://data.fixer.io/api/latest?access_key=271c4c569ff0be51a0563952018ba0cd";
				var httpClient = new HttpClient(new NativeMessageHandler());
				var response = await httpClient.GetAsync(url);
				if (response.IsSuccessStatusCode)
				{
					var conteudo = response.Content;
					var resultado = await conteudo.ReadAsStringAsync();
					var json = Newtonsoft.Json.Linq.JObject.Parse(resultado);
					await DisplayAlert("Xamarin", string.Format("US$ vale R$ {0}", json["rates"]["BRL"]), "Ok");
				}
				else {
					await DisplayAlert("Xamarin", response.StatusCode.ToString(), "Ok");
				}
			}
			catch (Exception ex)
			{
				await DisplayAlert("Xamarin", ex.Message, "Ok");

			}
		}
	}
}