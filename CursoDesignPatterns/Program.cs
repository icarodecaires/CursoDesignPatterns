using CursoDesignPatterns.ExercicioContaBancaria;
using CursoDesignPatterns.ExercicioDesconto;
using CursoDesignPatterns.ExercicioImposto;
using CursoDesignPatterns.TemplateMethod;
using System;



namespace CursoDesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			//Strategy
			//Imposto(); 

			//Strategy
			//Investimento(); 

			//Chain of Responsability
			//Desconto();

			//Chain of Responsability
			//RequisicaoConta(); 

			//Template Method
			TemplateMethod();

		}

		public static void TemplateMethod()
		{
			Imposto icpp = new ICPP();
			Imposto ickb = new ICKB();

			Orcamento orcamento = new Orcamento(500.0);

			CalculadorDeImpostos calculador = new CalculadorDeImpostos();

			calculador.RealizaCalculo(orcamento, icpp);

			Console.WriteLine(ickb.Calcula(orcamento));

			Console.ReadKey();
		}
		

		private static void RequisicaoConta()
		{
			ContaBancaria conta = new ContaBancaria(123213, 001, "icaro");

			RequisicaoConta requisicao = new RequisicaoConta();

			Console.WriteLine(requisicao.Requisicao(Formato.XML, conta));
			Console.ReadKey();
		}

		private static void Desconto()
		{
			CalculadorDeDesconto desconto = new CalculadorDeDesconto();

			Orcamento orcamento = new Orcamento(501);
			orcamento.addItem(new Item("Caneta",100));

			Console.WriteLine(desconto.Calcula(orcamento));
			Console.ReadKey();
		}


		private static void Investimento()
		{
			var conta = Conta.From(123, 100.00);
			var Investimento = new RealizadorDeInvestimentos();

			var resultado = Investimento.RealizaInvestimento(conta, new InvestimentoConservador());

			Console.WriteLine(resultado.Saldo);
			Console.ReadKey();
		}

		private static void Imposto()
		{
			Imposto iss = new ISS();
			Imposto icms = new ICMS();

			Orcamento orcamento = new Orcamento(500.0);

			CalculadorDeImpostos calculador = new CalculadorDeImpostos();

			calculador.RealizaCalculo(orcamento, iss);

			Console.ReadKey();
		}
	}
}
