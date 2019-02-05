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
	public partial class CadastroPage : ContentPage
	{
		public CadastroPage ()
		{
			InitializeComponent ();
		}

		private void BtnSalvar_Clicked(object sender, EventArgs e)
		{

		}
	}
}