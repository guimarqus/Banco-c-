using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Runtime.CompilerServices;
using static ConsoleApp32.Movimentacao;

namespace ConsoleApp32
{
    class Conta
    {
        public decimal SaldoBancario {  get; private set; }
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
      
        public  decimal ObterSaldoBancario()
        {
            return SaldoBancario = 0;
        }
        public static void SomarConta(double valor)
        {

            SaldoBancario += valor;
            Movimentacoes.Add(new Movimentacao(valor, TipoMovimentacao.Credito));
        }
     
    }
}
