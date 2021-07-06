using System;
using System.Collections.Generic;
using System.Text;

namespace CursoDesignPatterns.Modulo2.Memento
{
	public class Contrato
	{
		public DateTime Data { get; private set; }
		public string Cliente { get; private set; }
		public TipoContrato Tipo { get; private set; }

		public Contrato(DateTime data, string cliente, TipoContrato tipo)
		{
			Data = data;
			Cliente = cliente;
			Tipo = tipo;
		}

		public void Avanca()
		{
			if (this.Tipo == TipoContrato.Novo) this.Tipo = TipoContrato.Emandamento;
			else if (this.Tipo == TipoContrato.Emandamento) this.Tipo = TipoContrato.Acertado;
			else if (this.Tipo == TipoContrato.Acertado) this.Tipo = TipoContrato.Concluido;
		}

		public Estado SalvaEstado()
		{
			return new Estado(new Contrato(this.Data, this.Cliente, this.Tipo));
		}
	}
}
