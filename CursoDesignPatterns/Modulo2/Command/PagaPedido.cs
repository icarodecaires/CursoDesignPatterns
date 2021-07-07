using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Command
{
	public class PagaPedido : IComando
	{
		private Pedido Pedido;

		public PagaPedido(Pedido pedido)
		{
			Pedido = pedido;
		}

		public void Executa()
		{
			Console.WriteLine("Pagando o pedido do {0}", Pedido.Cliente);
			Pedido.Paga();
		}
	}
}
