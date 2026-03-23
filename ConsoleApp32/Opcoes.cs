using System;
using System.Globalization;
using System.Xml;

namespace ConsoleApp32
{
    class Opcoes
    {
        private int OpcoesMetodo { get; set; }
        public static void EscolherOpcoes(Conta conta)
        {
            MenuTexto.TextoMenuOptions();
            int escolha = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (escolha)
            {
                case 1:
                    Movimentacao.AcessarMenuMovimentacao(conta);
                    break;

                case 2:
                    Historico.MostrarHistorico(conta);
                    break;

                case 3:
                    Conta.MostrarSaldo(conta);
                    break;

                case 4:
                    MenuTexto.TextoCriarConta();
                    break;
                    

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            return;
        }

       
       


    }
}
