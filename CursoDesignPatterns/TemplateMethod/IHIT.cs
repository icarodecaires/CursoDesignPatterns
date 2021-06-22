using CursoDesignPatterns.ExercicioDesconto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
	public class IHIT : TemplateDeImpostoCondicional
	{
		public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
		{
			if (orcamento.Itens.Distinct().Count() != orcamento.Itens.Count())
			{
				return true;
			}

			return false;
		}

		public override double MaximaTaxacao(Orcamento orcamento)
		{
			return (orcamento.valor * 0.13) + 100;
		}

		public override double MinimaTaxacao(Orcamento orcamento)
		{
			return (orcamento.valor * 0.01) * orcamento.Itens.Count();
		}
	}
}
