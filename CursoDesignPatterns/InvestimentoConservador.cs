using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public class InvestimentoConservador : IEstrategiaInvestimento
	{
		public Conta Investir(Conta conta)
		{
			conta.AddSaldo(conta.Saldo * 0.08);
			return conta;
		}
	}
}
