namespace CursoDesignPatterns.ExercicioContaBancaria
{
	public interface IFormatoConta
	{
		IFormatoConta Proximo { get; set; }
		string RetornaConta(Formato formato, ContaBancaria conta);
	}
}
