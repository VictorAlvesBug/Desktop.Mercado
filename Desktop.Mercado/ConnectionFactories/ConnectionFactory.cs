using System;
using System.Data.SqlClient;

namespace Desktop.Mercado.ConnectionFactories
{
	public class ConnectionFactory
	{
		private readonly static string _serverAddress = 
			Environment.GetEnvironmentVariable("DB_ADDRESS");
		private readonly static string _userID = 
			Environment.GetEnvironmentVariable("DB_USER_ID") ?? "sa";
		private readonly static string _password = 
			Environment.GetEnvironmentVariable("DB_PASSWORD");

        public static SqlConnection AbrirConexao(string banco = "master")
		{
			string connectionString = 
				$"server={_serverAddress};database={banco};UID={_userID};password={_password}";

			SqlConnection con = new SqlConnection(connectionString);

			con.Open();

			return con;
		}
	}
}
