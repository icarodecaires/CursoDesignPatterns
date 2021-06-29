using CursoDesignPatterns.EstadosQueVariam;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioDesconto
{
	public class Orcamento
	{
		public double valor { get; set; }
		public List<Item> Itens { get; private set; }
		public IEstadoOrcamento EstadoOrcamento { get; set; }
		public bool DescontoAplicado { get; set; }

		public Orcamento(double valor)
		{
			this.valor = valor;
			this.EstadoOrcamento = new EmAprovacao();
			Itens = new List<Item>();
		}

		public void addItem(Item item)
		{
			Itens.Add(item);
		}

		public bool existe(string descricaoItem)
		{
			foreach(Item item in Itens)
			{
				if (item.Descricao.Equals(descricaoItem))
				{
					return true;
				}
			}

			return false;
		}

		public void AplicaDescontoExtra()
		{
			if (!this.DescontoAplicado)
			{
				EstadoOrcamento.AplicaDescontoExtra(this);
			} else
			{
				throw new Exception("Desconto ja aplicado");
			}
			
		}

		public void Aprova()
		{
			EstadoOrcamento.Aprova(this);
		}

		public void Reprova()
		{
			EstadoOrcamento.Reprova(this);
		}

		public void Finaliza()
		{
			EstadoOrcamento.Finaliza(this);
		}
	}
}
