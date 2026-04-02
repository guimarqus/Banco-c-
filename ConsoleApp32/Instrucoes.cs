namespace ConsoleApp32
{
    class Instrucoes
    {

        public static void MenuDasOpcoesIniciais(Conta conta)
        {

            Console.WriteLine($"Bem vindo {conta.Nome}");
            Console.WriteLine("Selecione a ação que deseja realizar");
            Console.WriteLine("1- Movimentar sua Conta");
            Console.WriteLine("2- Visualizar o Historico");
            Console.WriteLine("3- Acessar o Saldo");
            Console.WriteLine("4- Ver o Rendimento");
            Console.WriteLine("5- Sair");
            Console.WriteLine();

        }
        public static void TextoParaCriacaoDeConta()
        {
            Console.WriteLine("Digite os dados do usuario");
            Console.Write("Nome do usuario: ");
            Menu.SolicitarDadosParaConta();
            
            
        }
        public static void TextoParaEscolherTipoConta()
        {
            Console.WriteLine("Escolha o tipo de conta que deseja acessar:");
            Console.WriteLine("1 - Conta Corrente");
            Console.WriteLine("2 - Conta Poupança");
            Console.WriteLine("3 - Sair");
            
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
            Console.WriteLine($"O seu saldo atual é de R${conta.saldoBancario}");
        }
        public static void MostrarResultadoCredito(Conta conta, Movimentacao mov)
        {
            Console.WriteLine($"Foram adicionados R${mov.Valor} a sua conta, seu saldo atual é de R${conta.saldoBancario}");
            Console.WriteLine("Deseja realizar outra operação? (digite 0 para adicionar mais ao seu saldo ou digite " +
                "qualquer número para seguir ao menu) ");
           
        }

        public static void DebitarSaldo(Conta conta)
        {
            Console.WriteLine("Digite o valor que voce deseja debitar");
            Console.WriteLine($"O seu saldo atual é de R${conta.saldoBancario}");
        }
        public static void MostraResultadoDebito(Conta conta, Movimentacao mov)
        {
            Console.WriteLine($"O seu saldo atual é R${conta.saldoBancario}");
            Console.WriteLine("Deseja realizar outra operação? (digite 0 para continuar ou digite " +
            "qualquer número para seguir ao menu) ");
             
            
        }
       
        
        public static void SairDoHistorico()
        {
            Console.WriteLine("--------------------------------------------------------------------------------------");
            Console.WriteLine("Deseja voltar ao menu de operações? (digite qualquer numero para prosseguir)");
            Console.WriteLine("Para ver o saldo da sua conta digite 1");
        }
        public static void NenhumaMovimentacao()
        {
            Console.WriteLine("Nenhuma movimentação registrada.");
        }
        
        public static void SairDoSaldo()
        {
            Console.WriteLine();
            Console.WriteLine("Deseja voltar ao menu de operações? (digite 0 para continuar no menu ou qualquer numero para prosseguir)");
        }

       

    }
}
