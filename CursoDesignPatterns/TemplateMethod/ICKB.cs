using CursoDesignPatterns.ExercicioDesconto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
	public class ICKB : TemplateDeImpostoCondicional
	{
		public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.valor > 500 && TemItemMaiorQue100Reais(orcamento);
		}

		public override double MaximaTaxacao(Orcamento orcamento)
		{
			return orcamento.valor * 0.10;
		}

		public override double MinimaTaxacao(Orcamento orcamento)
		{
			return orcamento.valor * 0.06;
		}

		private bool TemItemMaiorQue100Reais(Orcamento orcamento)
		{
			foreach(Item item in orcamento.Itens)
			{
				if (item.Valor > 100) return true;
			}

			return false;
		}
	}
}
