using static ConsoleApp32.Enums;
using static ConsoleApp32.Movimentacao;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp32
{
    class ContaPoupanca : Conta
    {
     
        public ContaPoupanca(string nome) : base(nome)
        {
        }


        public override void SomarContaCredito (decimal valor)
        {
            saldoBancario += valor;
            
        }

        public override void SubtrairContaDebito(decimal valor)
        {
            if (saldoBancario < valor)
            {
                Console.WriteLine("Não foi possivel debitar na sua Poupança");
                return;
            }
            Console.WriteLine($"Foram debitados R${valor} da sua conta");
            saldoBancario -= valor;
            
        }
      
       
        
        public override void MostrarSaldo(Conta conta)
        {
            bool continua = true;
            while (continua)
            {
                Console.WriteLine();
                Console.Write($" Bem vindo {conta.Nome} o saldo atual de sua Poupança é \n");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{conta.saldoBancario:C}");
                Console.ResetColor();
                Instrucoes.SairDoSaldo();
                int optSaldo = int.Parse(Console.ReadLine());
                if (optSaldo > 0)
                {
                    continua = false;
                    Menu.MenuOpcoesIniciais(conta);
                }
                else
                {
                    continua = true;

                }

            }
        }
        public override bool PermiteRendimento()
        {
            return true;
        }

        public override void MostrarRendimento(Conta conta)
        {
            bool continua = true;
            while (continua)
            {
                decimal rendimento = conta.saldoBancario * 0.001m;
                rendimento += conta.saldoBancario;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.WriteLine($" Saldo atual da Poupança {conta.saldoBancario:C} com a renda diária de 0.1% é R${rendimento}");
                Console.ResetColor();
                Instrucoes.SairDoSaldo();
                int optSaldo = int.Parse(Console.ReadLine());
                if (optSaldo > 0)
                {
                    continua = false;
                    Menu.MenuOpcoesIniciais(conta);
                }
                else
                {
                    continua = true;

                }
            }
        }
    }
}

       
    

