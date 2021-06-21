namespace CursoDesignPatterns
{
	public class Conta
	{
		public int NumeroConta { get; private set; }
		public double Saldo { get; private set; }

		public Conta(int numeroConta, double saldo)
		{
			NumeroConta = numeroConta;
			Saldo = saldo;
		}

		public static Conta From(int numeroConta, double saldo)
		{
			return new Conta(numeroConta,saldo);
		}

		public void AddSaldo(double saldo)
		{
			this.Saldo += saldo;
		}
	}
}
