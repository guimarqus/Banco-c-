using System;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp32
{
    class Conta
    {
        public decimal SaldoBancario {  get; private set; }
        public int Id { get; set; }
        public string Nome { get; private set; }
        


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
      
        public  decimal ObterSaldoBancario()
        {
            return SaldoBancario = 0;
        }

     
    }
}
