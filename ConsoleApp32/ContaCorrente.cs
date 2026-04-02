using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp32
{
    class ContaCorrente : Conta
    {

        

        public ContaCorrente(string nome) : base(nome)
        {
        }

        public override void MostrarSaldo(Conta conta)
        {
            bool continua = true;
            while (continua)
            {
                Console.WriteLine();
                Console.Write($"Bem vindo {conta.Nome} o saldo atual da conta Corrente é  de ");
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
        

        

        public override void SomarContaCredito(decimal valor)
        {
            saldoBancario += valor;
            
        }

        public override void SubtrairContaDebito(decimal valor)
        {
            if (saldoBancario - valor < -1000)
            {
                Console.WriteLine("Não é possível debitar: limite negativo atingido.");
                return;
            }

            saldoBancario -= valor;
            
        }
    }
}
