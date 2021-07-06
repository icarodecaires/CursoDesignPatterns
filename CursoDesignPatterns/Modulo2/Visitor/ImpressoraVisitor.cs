using CursoDesignPatterns.Modulo2.Interpreter;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Visitor
{
	public class ImpressoraVisitor : IVisitor
	{
		public void ImprimeSoma(Soma soma)
		{
			Console.Write("(");
			soma.ValorEsquerda.Aceita(this);
			Console.Write(" + ");
			soma.ValorDireita.Aceita(this);
			Console.Write(")");
		}

		public void ImprimeSubtracao(Subtracao subtracao)
		{
			Console.Write("(");
			subtracao.ValorEsquerda.Aceita(this);
			Console.Write("-");
			subtracao.ValorDireita.Aceita(this);
			Console.Write(")");
		}

		public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
		{
			Console.Write("(");
			multiplicacao.ValorEsquerda.Aceita(this);
			Console.Write(" * ");
			multiplicacao.ValorDireita.Aceita(this);
			Console.Write(")");
		}

		public void ImprimeDivisao(Divisao divisao)
		{
			Console.Write("(");
			divisao.ValorEsquerda.Aceita(this);
			Console.Write(" / ");
			divisao.ValorDireita.Aceita(this);
			Console.Write(")");
		}

		public void ImprimeNumero(Numero numero)
		{
			Console.Write(numero.Valor);
		}
	}
}
