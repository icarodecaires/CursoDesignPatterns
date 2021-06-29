using CursoDesignPatterns.ExercicioImposto;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.TemplateMethod
{
	public interface IEstadoConta
	{
		void Saque(Conta conta, double valor);
		void Deposito(Conta conta, double valor);
	}
}
