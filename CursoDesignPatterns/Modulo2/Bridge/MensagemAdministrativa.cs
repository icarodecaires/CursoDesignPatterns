using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Bridge
{
	public class MensagemAdministrativa :IMensagem
	{
        private string nome;

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

		public IEnviador Enviador { get; set; }

		public void Envia()
        {
			this.Enviador.Envia(this);
        }

		public string Formata()
		{
			return String.Format("Mensagem administrativa para {0}", nome);
		}
	}
}
