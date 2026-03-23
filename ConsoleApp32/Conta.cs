using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using static ConsoleApp32.Movimentacao;

namespace ConsoleApp32
{
    class Conta
    {
        public decimal SaldoBancario {  get; private set; }
        public int Id { get; set; }
        public string Nome { get; private set; }
        public List<Movimentacao> Movimentacoes { get; private set; }
        public DateTime Date { get; private set; }


        private Conta(string nome)
        {
            Id = Random.Shared.Next();
            Nome = nome.ToUpper();
            SaldoBancario = ObterSaldoBancario();
            Movimentacoes = new List<Movimentacao>();
            Date = DateTime.Now;
        }

        public static Conta CriarConta(string nome)
        {
          
            return new Conta(nome);
        }
        public  decimal ObterSaldoBancario()
        {
            return SaldoBancario;
        }
        public void SomarContaCredito(decimal valor)
        {

            SaldoBancario += valor;
            Movimentacoes.Add(Movimentacao.CriarMov(valor, TipoMovimentacao.Credito));

        }
        public void SubtrairContaDebito(decimal valor)
        {

            SaldoBancario -= valor;
            Movimentacoes.Add(Movimentacao.CriarMov(valor, TipoMovimentacao.Debito));
            
        }

        public static void MostrarSaldo(Conta conta)
        {
            bool continua = true;
            while (continua)
            {
                Console.Write($"Bem vindo {conta.Nome} o seu saldo atual é de ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{ conta.SaldoBancario}$");
                Console.ResetColor();
                Console.WriteLine();
                Console.WriteLine("Deseja voltar ao menu de operações? (digite 0 para continuar no menu ou qualquer numero para prosseguir)");
                int optSaldo = int.Parse(Console.ReadLine());
                if (optSaldo > 0)
                {
                    continua = false;
                    Opcoes.EscolherOpcoes(conta);
                }
                else
                {
                    continua = true;
                   
                }

            }
        }

    }
}
