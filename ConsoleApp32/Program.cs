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
            Console.WriteLine(nome);



        }

    }
}