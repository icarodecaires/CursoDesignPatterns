using CursoDesignPatterns.Modulo2.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Interpreter
{
	public class Soma : IExpressao
	{
		public IExpressao ValorEsquerda { get; private set; }
		public IExpressao ValorDireita { get; private set; }

		public Soma(IExpressao valorEsquerda, IExpressao valorDireita)
		{
			ValorEsquerda = valorEsquerda;
			ValorDireita = valorDireita;
		}

		public int Avaliar()
		{
			return ValorEsquerda.Avaliar() + ValorDireita.Avaliar();
		}

		public void Aceita(IVisitor impressora)
		{
			impressora.ImprimeSoma(this);
		}
	}
}
