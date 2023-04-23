namespace Desktop.Mercado.Utils
{
	public static class Criptografia
	{
		public static string RetornarHash(string texto)
		{
			return EasyEncryption.MD5.ComputeMD5Hash(texto);
		}
	}
}
