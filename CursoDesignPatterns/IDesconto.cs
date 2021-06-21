using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns
{
	public interface IDesconto
	{
		IDesconto Proximo { get; set; }
		double Desconta(Orcamento orcamento);
	}
}
