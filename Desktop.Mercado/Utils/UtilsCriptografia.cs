namespace Desktop.Mercado.Utils
{
	public static class UtilsCriptografia
	{
		public static string RetornarHash(string texto)
		{
			return EasyEncryption.MD5.ComputeMD5Hash(texto);
		}
	}
}
