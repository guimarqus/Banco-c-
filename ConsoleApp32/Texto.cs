using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp32.Movimentacao;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp32
{
    class Texto
    {

        public static void TextoMenuDasOpcoesIniciais()
        {

            Console.WriteLine("Bem vindo ao Menu ");
            Console.WriteLine("Selecione a ação que deseja realizar");
            Console.WriteLine("1- Movimentar sua Conta");
            Console.WriteLine("2- Visualizar o Historico");
            Console.WriteLine("3- Acessar o Saldo");
            Console.WriteLine("4- Sair");
            Console.WriteLine();

        }
        public static void TextoParaCriacaoDeConta()
        {
            Console.WriteLine("Digite os dados do usuario");
            Console.Write("Nome do usuario: ");
            var nome = Console.ReadLine();
            var conta = Conta.CriarConta(nome);
            Opcoes.MenuOpcoesIniciais(conta);
        }

        public static void TextoParaEscolhaDasOperacoes()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo");
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Credito");
            Console.WriteLine("2 - Debito");
            Console.WriteLine("3 - Sair");

        }

        public static void AdicionarCredito(Conta conta)
        {

            Console.WriteLine("Digite o valor que voce deseja adicionar");
            Console.WriteLine($"O seu saldo atual é de {conta.SaldoBancario}$");
        }
        public static void MostrarResultadoCredito(Conta conta, Movimentacao mov)
        {
            Console.WriteLine($"Foram adicionados {mov.Valor}$ a sua conta, seu saldo atual é de {conta.SaldoBancario}$");
            Console.WriteLine("Deseja realizar outra operação? (digite 0 para adicionar mais ao seu saldo ou digite " +
                "qualquer número para seguir ao menu) ");
        }

        public static void DebitarSaldo(Conta conta)
        {
            Console.WriteLine("Digite o valor que voce deseja debitar");
            Console.WriteLine($"O seu saldo atual é de {conta.SaldoBancario}$");
        }
        public static void MostraResultadoDebito(Conta conta, Movimentacao mov)
        {
            Console.WriteLine($"Foram debitados {mov.Valor}$ da sua conta, seu saldo atual é {conta.SaldoBancario}$");
            Console.WriteLine("Deseja realizar outra operação? (digite 0 para continuar ou digite " +
            "qualquer número para seguir ao menu) ");

        }
        public static void SairDoHistorico()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Deseja voltar ao menu de operações? (digite 0 para continuar no menu ou qualquer numero para prosseguir)");
        }
        public static void SairDoSaldo()
        {
            Console.WriteLine();
            Console.WriteLine("Deseja voltar ao menu de operações? (digite 0 para continuar no menu ou qualquer numero para prosseguir)");
        }

    }
}
