using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Bridge
{
	public class MensagemCliente : IMensagem
	{
        private string nome;

        public MensagemCliente(string nome)
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
			return String.Format("Mensagem para o cliente {0}", nome); throw new NotImplementedException();
		}
	}
}
