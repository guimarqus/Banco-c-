using ConsoleApp32;
using System;

namespace Banco
{

    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os dados do usuario");
            Console.Write("Nome do usuario: ");
            var nome = Console.ReadLine();  
            var conta = Conta.CriarConta(nome);
                 
            Console.WriteLine("Bem vindo ao Menu ");
            Console.WriteLine("Selecione a ação que deseja realizar");
            Console.WriteLine("1- Movimentar sua Conta");
            Console.WriteLine("2- Visualizar o Historico");
            Console.WriteLine("3- Acessar o Saldo");
            Console.WriteLine("4- Sair");
            Console.WriteLine();
            int escolha = int.Parse(Console.ReadLine());
            var opcao = Opcoes.EscolherOpcoes(escolha);
           

        }

    }
}