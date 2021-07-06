using CursoDesignPatterns.CriacaoObjetosBuilder;
using CursoDesignPatterns.EstadosQueVariam;
using CursoDesignPatterns.ExercicioContaBancaria;
using CursoDesignPatterns.ExercicioDesconto;
using CursoDesignPatterns.ExercicioImposto;
using CursoDesignPatterns.Modulo2.Bridge;
using CursoDesignPatterns.Modulo2.Factory;
using CursoDesignPatterns.Modulo2.Flyweight;
using CursoDesignPatterns.Modulo2.Interpreter;
using CursoDesignPatterns.Modulo2.Memento;
using CursoDesignPatterns.Modulo2.Visitor;
using CursoDesignPatterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Data;

namespace CursoDesignPatterns
{
	class Program
	{
		static void Main(string[] args)
		{
			//Cada método é referente a uma aula

			//Strategy
			//Imposto(); 

			//Strategy
			//Investimento(); 

			//Chain of Responsability
			//Desconto();

			//Chain of Responsability
			//RequisicaoConta(); 

			//Template Method
			//TemplateMethod();

			//Estados que variam - STADE
			//Stade();

			//Criação de Objetos e Builder e Observer
			//CriacaoObjetosBuilder();

			//SEGUNDO MODULO DO CURSO

			//Factory
			//Factory()

			//Flyweght
			//Flyweght();

			//Interpreter
			//Interpreter();

			//Visitor
			//Visitor();

			//Bridge
			Bridge();


		}

		private static void Bridge()
		{
			IEnviador enviador = new EnviaPorEmail();
			IMensagem mensagem = new MensagemAdministrativa("victor");
			mensagem.Enviador = enviador;

			mensagem.Envia();
		}

		private static void Visitor()
		{
			IExpressao esquerda = new Soma(new Numero(10), new Numero(10));
			IExpressao direita = new Subtracao(new Numero(10), new Numero(5));

			Soma soma = new Soma(esquerda, direita);
			Console.WriteLine(soma.Avaliar());

			ImpressoraVisitor impressora = new ImpressoraVisitor();

			soma.Aceita(impressora);
			
		}

		private static void Interpreter() 
		{

			IExpressao esquerda = new Soma(new Numero(10), new Numero(10));
			IExpressao direita = new Subtracao(new Numero(10), new Numero(5));

			int resultado = new Soma(esquerda, direita).Avaliar();
			Console.WriteLine(resultado);

			resultado = new Multiplicacao(direita, direita).Avaliar();
			Console.WriteLine(resultado);

			resultado= new Divisao(direita, direita).Avaliar();
			Console.WriteLine(resultado);
		}

		private static void Memento()
		{
			Historico historico = new Historico();
			Contrato c = new Contrato(DateTime.Now, "Teste", TipoContrato.Novo);

			historico.Adiciona(c.SalvaEstado());
			c.Avanca();
			Console.WriteLine(c.Tipo);


			historico.Adiciona(c.SalvaEstado());
			c.Avanca();
			Console.WriteLine(c.Tipo);

			Console.WriteLine(historico.Pega(0).Contrato.Tipo);
		}

		private static void Flyweght()
		{
			NotasMusicais notas = new NotasMusicais();
			IList<INota> musica = new List<INota>
			{
				notas.pega("do"),
				notas.pega("re"),
				notas.pega("mi"),
				notas.pega("fa"),
				notas.pega("fa"),
				notas.pega("fa")
			};

			Piano piano = new Piano();
			piano.Toca(musica);

		}

		private static void Factory()
		{
			IDbConnection conexao = new ConnectionFactory().GetConnection();

			IDbCommand comando = conexao.CreateCommand();
			comando.CommandText = "SELECT * FROM tabela";
		}

		private static void CriacaoObjetosBuilder()
		{
			NotaFiscalBuilder criador = new NotaFiscalBuilder();

			criador.ParaEmpresa("Empresa teste");
			criador.ComCnpj("23.123.123/0001-12");
			criador.ComItem(new ItemDaNota("item 1", 100));
			criador.NaDataAtua();
			criador.ComObervacoes("observações da nota");

			//Implementação do padrão Observer
			criador.AddAcao(new EnviadorDeEmail());
			criador.AddAcao(new EnviaSMS());
			criador.AddAcao(new NotaFiscalDAO());

			NotaFiscal nd = criador.ConstroiNota();

			Console.ReadKey();
		}

		private static void Stade()
		{
			/*
				Orcamento orcamento = new Orcamento(100);

				orcamento.Reprova();
				orcamento.AplicaDescontoExtra();

				Console.WriteLine(orcamento.valor);
				Console.ReadKey();
			*/

			//Exercicio conta
			Conta conta = new Conta(123, 100);
			Console.WriteLine(conta.Saldo);

			conta.Deposito(50);
			Console.WriteLine(conta.Saldo);
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
