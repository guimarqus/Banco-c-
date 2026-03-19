using System;

using System.Globalization;
using System.Xml;

namespace ConsoleApp32
{
    class Opcoes
    {
        public Opcoes()
        {
            Console.WriteLine("Bem vindo ao menu#");
            Console.WriteLine("Selecione a ação que deseja realizar");
            Console.WriteLine("1- Movimentar sua Conta");
            Console.WriteLine("2- Visualizar o Historico");
            Console.WriteLine("3- Acessar o Saldo");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1: ();
                    break;
            }
        }



    }
}
