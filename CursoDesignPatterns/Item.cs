namespace CursoDesignPatterns
{
	public class Item
	{
		public string Descricao { get; private set; }

		public Item(string descricao)
		{
			Descricao = descricao;
		}
	}
}