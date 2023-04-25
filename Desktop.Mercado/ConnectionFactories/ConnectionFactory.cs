using System;
using System.Data.SqlClient;
using System.Windows.Forms;

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
			if (string.IsNullOrEmpty(_serverAddress)
				|| string.IsNullOrEmpty(_password))
			{
				MessageBox.Show("Configure as variáveis de ambiente \"DB_ADDRESS\" e \"DB_PASSWORD\" e reinicie o Visual Studio", "Erro");
			}

			string connectionString = 
				$"server={_serverAddress};database={banco};UID={_userID};password={_password}";

			SqlConnection con = new SqlConnection(connectionString);

			con.Open();

			return con;
		}
	}
}
