using DevExpress.XtraEditors;

namespace Desktop.Mercado.Utils
{
	public class Loading
	{
		private readonly SimpleButton _botao;
		private bool _estaCarregando;
		private string _textoOriginal;

		public Loading(SimpleButton botao)
		{
			_botao = botao;
			_estaCarregando = false;
		}

		public void Habilitar(string textoLoading = "CARREGANDO...")
		{
			if (_estaCarregando)
				return;

			_textoOriginal = _botao.Text;
			_botao.Enabled = false;
			_botao.Text = textoLoading;
			_botao.Update();
			_estaCarregando = true;
		}

		public void Desabilitar()
		{
			if (!_estaCarregando)
				return;

			_botao.Enabled = true;
			_botao.Text = _textoOriginal;
			_botao.Update();
			_estaCarregando = false;
		}
	}
}
