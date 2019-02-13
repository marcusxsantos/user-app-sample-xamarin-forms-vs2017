using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace UsuarioApp
{
    public interface IConfig
    {
		string DiretorioDB();
		ISQLitePlatform Plataforma();
    }
}
