using CursoDesignPatterns.Modulo2.Interpreter;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Visitor
{
	public interface IVisitor
	{
		void ImprimeSoma(Soma soma);
		void ImprimeSubtracao(Subtracao subtracao);
		void ImprimeNumero(Numero numero);
		void ImprimeMultiplicacao(Multiplicacao multiplicacao);
		void ImprimeDivisao(Divisao divisao);
	}
}
