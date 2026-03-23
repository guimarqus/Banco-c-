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
                    return;
                }

                Console.WriteLine($"Histórico da conta de {conta.Nome}:");
                foreach (var mov in conta.Movimentacoes)
                {
                    Console.WriteLine();
                    Console.WriteLine($"ID: {mov.Id} | Tipo: {mov.TipodeMovimentacao} | Valor: {mov.Valor:C}  | Data: {conta.Date}");
                }
                Console.WriteLine("--------------------------------------------------------------------------------------");
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
