using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        //definicao dos atributos internos de classe
        private Int32 numero;
        private decimal LimiteCredito;
        private decimal saldo;

        public int Numero { get => numero; set => numero = value; }
        public decimal LimiteCredito1 { get => LimiteCredito; set => LimiteCredito = value; }
        public decimal Saldo { get => saldo; set => saldo = value; }


        //criação dos metodos de classe
        public void Sacar(decimal valor)
        {
            contadorConta++;
            Saldo = Saldo - valor;
            Console.WriteLine("Saque realizado com sucesso! Valor sacado: " + valor.ToString("C"));
        }
        public void Depositar(decimal valor)
        {
            contadorConta++;
            Saldo = Saldo + valor;
            Console.WriteLine("Depósito realizado com sucesso! Valor depositado: " + valor.ToString("C"));
        }
        public void sacar(decimal valor)
        {
            
                Sacar(valor);
        }



    }
}
