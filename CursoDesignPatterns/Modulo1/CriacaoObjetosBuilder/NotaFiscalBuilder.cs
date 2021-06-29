using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.CriacaoObjetosBuilder
{
	public class NotaFiscalBuilder
	{
		public String RazaoSocial { get; private set; }
		public String Cnpj { get; private set; }
		public String Observacoes { get; private set; }
		public DateTime Data { get; private set; }
		public double Valortotal { get; private set; }
		public double Impostos { get; private set; }
		public IList<ItemDaNota> todosItens = new List<ItemDaNota>();
		private IList<AcaoAposCriarNota> todasAcoesParaExecutar = new List<AcaoAposCriarNota>();

		public NotaFiscal ConstroiNota()
		{
			NotaFiscal nota =  new NotaFiscal(RazaoSocial, Cnpj, Data, Valortotal, Impostos, Observacoes);

			foreach(AcaoAposCriarNota acao in todasAcoesParaExecutar)
			{
				acao.Executa(nota);
			}

			return nota;
		}

		public void AddAcao(AcaoAposCriarNota NovaAcao)
		{
			todasAcoesParaExecutar.Add(NovaAcao);
		}

		public void ParaEmpresa(String razaoSocial)
		{
			RazaoSocial = razaoSocial;
		}

		public void ComCnpj(String cnpj)
		{
			Cnpj = cnpj;
		}

		public void NaDataAtua()
		{
			Data = DateTime.Now;
		}

		public void ComItem(ItemDaNota item)
		{
			todosItens.Add(item);
			Valortotal += item.Valor;
			Impostos += item.Valor * 0.05;
		}

		public void ComObervacoes(String obs)
		{
			Observacoes = obs;
		}
	}
}
