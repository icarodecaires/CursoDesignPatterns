using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
	public class NotaFiscal
	{
		public String RazaoSocial { get; set; }
		public String  Cnpj { get; set; }
		public DateTime DataEmissao { get; set; }
		public double ValorBruto { get; set; }
		public double Impostos { get; set; }
		public IList<ItemDaNota> Itens { get; set; }
		public String Observacoes { get; set; }

		public NotaFiscal(string razaoSocial, string cnpj, DateTime dataEmissao, double valorBruto, double impostos, string observacoes)
		{
			RazaoSocial = razaoSocial;
			Cnpj = cnpj;
			DataEmissao = dataEmissao;
			ValorBruto = valorBruto;
			Impostos = impostos;
			Observacoes = observacoes;
		}
	}
}
