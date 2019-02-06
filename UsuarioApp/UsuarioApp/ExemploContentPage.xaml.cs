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
	public partial class ExemploContentPage : ContentPage
	{
		public ExemploContentPage ()
		{
			InitializeComponent ();

			base.Title = "Exemplo de Content Page";
		}
	}
}