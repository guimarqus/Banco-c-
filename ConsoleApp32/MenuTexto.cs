using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp32
{
     class MenuTexto
    {
        public string Text { get; set; }

        public static void TextoMenuOptions() 
        {
            
            Console.WriteLine("Bem vindo ao Menu ");
            Console.WriteLine("Selecione a ação que deseja realizar");
            Console.WriteLine("1- Movimentar sua Conta");
            Console.WriteLine("2- Visualizar o Historico");
            Console.WriteLine("3- Acessar o Saldo");
            Console.WriteLine("4- Sair");
            Console.WriteLine();

        }

        public static void TextoCriarConta()
        {
            Console.WriteLine("Digite os dados do usuario");
            Console.Write("Nome do usuario: ");
            var nome = Console.ReadLine();
            var conta = Conta.CriarConta(nome);
            Opcoes.EscolherOpcoes(conta);

        }
        public MenuTexto(string text)
        {
            Text = text;
            
        }
    }
}
