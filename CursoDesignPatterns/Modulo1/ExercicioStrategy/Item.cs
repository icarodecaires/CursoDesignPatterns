using System;

namespace CursoDesignPatterns.ExercicioDesconto
{
	public class Item
	{
		public string Descricao { get; private set; }
		public double Valor { get; set; }

		public Item(string descricao, double valor)
		{
			Descricao = descricao;
			Valor = valor;
		}

		public override bool Equals(object obj)
		{
			return obj is Item item &&
				   Descricao == item.Descricao;
		}

		public override int GetHashCode()
		{
			return HashCode.Combine(Descricao);
		}
	}
}