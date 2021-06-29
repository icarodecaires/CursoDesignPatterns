using CursoDesignPatterns.ExercicioImposto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
	public class ContaNegativa : IEstadoConta
	{
		public void Deposito(Conta conta, double valor)
		{
			conta.Saldo += valor * 0.95;
			if(conta.Saldo > 0)
			{
				conta.EstadoConta = new ContaPositiva();
			}
		}

		public void Saque(Conta conta, double valor)
		{
			throw new Exception("Conta sem saldo");
		}
	}
}
