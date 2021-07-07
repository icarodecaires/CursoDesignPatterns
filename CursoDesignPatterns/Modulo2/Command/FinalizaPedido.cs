using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Command
{
	public class FinalizaPedido : IComando
	{
		private Pedido Pedido;

		public FinalizaPedido(Pedido pedido)
		{
			Pedido = pedido;
		}

		public void Executa()
		{
			Console.WriteLine("Finalizando o pedido do {0}", Pedido.Cliente);
			Pedido.Finaliza();
		}
	}
}
