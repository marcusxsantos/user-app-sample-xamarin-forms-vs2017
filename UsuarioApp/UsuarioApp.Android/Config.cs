using SQLite.Net.Interop;
using Xamarin.Forms;

[assembly: Dependency(typeof(UsuarioApp.Droid.Config))]
namespace UsuarioApp.Droid
{
	public class Config : IConfig
	{
		public string DiretorioDB()
		{
			return System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
		}

		public ISQLitePlatform Plataforma()
		{
			return new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();
		}
	}
}