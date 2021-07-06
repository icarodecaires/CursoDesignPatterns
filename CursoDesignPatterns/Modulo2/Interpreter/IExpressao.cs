using CursoDesignPatterns.Modulo2.Visitor;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Interpreter
{
	public interface IExpressao
	{
		int Avaliar();
		void Aceita(IVisitor impressora);
	}
}
