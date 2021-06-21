﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.ExercicioDesconto
{
	public class Orcamento
	{
		public double valor { get; private set; }
		public List<Item> Itens { get; private set; }

		public Orcamento(double valor)
		{
			this.valor = valor;
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
	}
}