using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
    class Historico
    {
        private Conta conta;

        public Historico(Conta conta) 
        { this.conta = conta; }


        public static void MostrarHistorico(Conta conta)
        {
            bool continua = true;
            while (continua)
            {
                if (conta.Movimentacoes.Count == 0)
                {
                    Console.WriteLine("Nenhuma movimentação registrada.");
                    Texto.SairDoHistorico();
                    int optSaldo = int.Parse(Console.ReadLine());
                    if (optSaldo > 0)
                    {
                        continua = false;
                        Opcoes.MenuOpcoesIniciais(conta);
                    }
                    else
                    {
                        continua = true;

                    }
                }

                Console.WriteLine($"Histórico da conta de {conta.Nome}:");
                foreach (var mov in conta.Movimentacoes)
                {
                    Console.WriteLine();
                    Console.WriteLine($"ID: {mov.Id} | Tipo: {mov.TipodeMovimentacao} | Valor: {mov.Valor:C}  | Data: {conta.Date}");
                }
                Texto.SairDoHistorico();
                int optOutroSaldo = int.Parse(Console.ReadLine());
                if (optOutroSaldo > 1)
                {
                    continua = false;
                    Opcoes.MenuOpcoesIniciais(conta);
                }
                else
                {
                    Conta.MostrarSaldo(conta);
                    continua = false;

                }
            }
        }
    }
}
