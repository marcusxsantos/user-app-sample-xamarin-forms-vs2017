using System;
using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(UsuarioApp.iOS.Config))]
namespace UsuarioApp.iOS
{
	class Config : IConfig
	{
		public string DiretorioDB()
		{
			return System.IO.Path.Combine(System.Environment.GetFolderPath(Environment.SpecialFolder.Personal),
				"..", "Library");

		}

		public ISQLitePlatform Plataforma()
		{
			return new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
		}
	}
}