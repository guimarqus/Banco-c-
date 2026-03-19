using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp32
{
    class Conta
    {
        public double SaldoBancario {  get; private set; }
        public int Id { get; set; }
        public string Nome { get; private set; }
        public List<Movimentacao> Movimentacoes { get; set; }


        private Conta(string nome)
        {
            Id = Random.Shared.Next();
            Nome = nome.ToUpper();
            SaldoBancario = ObterSaldoBancario();
        }

        public static Conta CriarConta(string nome)
        {
          
            return new Conta(nome);
            
            
        }
      
        public double ObterSaldoBancario()
        {
            return SaldoBancario = 0;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
