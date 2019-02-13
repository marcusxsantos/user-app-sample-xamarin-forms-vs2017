using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace UsuarioApp
{
	public class AcessoDados<T> : IDisposable where T : class
	{
		private SQLite.Net.SQLiteConnection conexao;

		public AcessoDados()
		{
			var config = DependencyService.Get<IConfig>();
			
			conexao = new SQLite.Net.SQLiteConnection(config.Plataforma(), System.IO.Path.Combine(config.DiretorioDB(), "UsuarioApp.db3"));

			conexao.CreateTable<T>();
		}

		public void Inserir(T item)
		{
			conexao.Insert(item);
		}

		public void Atualizar(T item)
		{
			conexao.Update(item);
		}

		public void Excluir(T item)
		{
			conexao.Delete(item);
		}

		public List<T> Listar()
		{
			return conexao.Table<T>().ToList();
		}


		public void Dispose()
		{
			conexao.Close();
		}
	}
}
