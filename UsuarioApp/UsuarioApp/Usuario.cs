using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite.Net.Attributes;

namespace UsuarioApp
{
    public class Usuario
    {
		[PrimaryKey, AutoIncrement]
		public int Codigo { get; set; }

		public string Nome { get; set; }

		public bool Filhos { get; set; }

		public string Estado { get; set; }

		public DateTime Nascimento { get; set; }

	}
}
