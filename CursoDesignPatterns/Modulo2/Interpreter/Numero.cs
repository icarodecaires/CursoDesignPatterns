using CursoDesignPatterns.Modulo2.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Interpreter
{
	public class Numero : IExpressao
	{
		public int Valor { get; private set; }

		public Numero(int valor)
		{
			Valor = valor;
		}

		public int Avaliar()
		{
			return Valor;
		}

		public void Aceita(IVisitor impressora)
		{
			impressora.ImprimeNumero(this);
		}
	}
}
