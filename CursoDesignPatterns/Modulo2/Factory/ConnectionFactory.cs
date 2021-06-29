using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Factory
{
	public class ConnectionFactory
	{
		public IDbConnection GetConnection()
		{
			IDbConnection conexao = new SqlConnection();
			conexao.ConnectionString = "User Id=root; Password=123456;server=localhost;Database=meuBanco";
			conexao.Open();

			return conexao;
		}

	}
}
