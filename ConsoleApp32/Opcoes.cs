using System;
using System.Globalization;
using System.Xml;

namespace ConsoleApp32
{
    class Opcoes
    {
        private int opcoes { get; set; }
        public static int EscolherOpcoes(int _opcoes, decimal saldo)
        {
            
            Console.Clear();
            switch (_opcoes)
            {
                case 1:
                    Console.WriteLine("Movimentar conta");
                    Movimentacao.AcessarMovimentacao(saldo);
                    break;

                case 2:
                    Console.WriteLine("Visualizar histórico");
                    break;

                case 3:
                    Console.WriteLine("Acessar saldo");
                    break;

                case 4:
                    

                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }

            return _opcoes;
        }

       
       


    }
}
