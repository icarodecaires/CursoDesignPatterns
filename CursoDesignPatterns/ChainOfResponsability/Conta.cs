using CursoDesignPatterns.TemplateMethod;

namespace CursoDesignPatterns.ExercicioImposto
{
	public class Conta
	{
		public int NumeroConta { get; private set; }
		public double Saldo { get; set; }
		public IEstadoConta EstadoConta { get; set; }

		public Conta(int numeroConta, double saldo)
		{
			NumeroConta = numeroConta;
			Saldo = saldo;
			EstadoConta = new ContaPositiva();
		}

		public static Conta From(int numeroConta, double saldo)
		{
			return new Conta(numeroConta,saldo);
		}

		public void AddSaldo(double saldo)
		{
			this.Saldo += saldo;
		}

		public void Deposito(double valor)
		{
			EstadoConta.Deposito(this, valor);
		}

		public void Saque(double valor)
		{
			EstadoConta.Saque(this, valor);
		}
	}
}
