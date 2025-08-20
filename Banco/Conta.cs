using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Conta
    {
        //definição dos atributos internos de classe
        private Int32 numero;
        private decimal LimiteCredito;
        private decimal saldo;
        private DateTime dataAbertura;
        private static int contadorConta = 0; // Adicionado campo estático

        public int Numero 
        { 
            get => numero; 
            set => numero = value;
        }
        public decimal LimiteCredito1 
        { 
            get => LimiteCredito; 
            set => LimiteCredito = value; 
        }
        public decimal Saldo 
        { 
            get => saldo; 
            set => saldo = value;
        }

        //criação dos métodos de classe
        public void Sacar(decimal valor)
        {
            contadorConta++;
           if (valor > Saldo + LimiteCredito)
            {
                throw new Exception("Saldo insuficiente para realizar o saque. Verifique seu saldo e limite de crédito.");
            }
            Saldo -= valor;
        
           if (saldo < 0)
            {
                Console.WriteLine("Atenção: você está usando o limite de crédito!");
            
            }
        }
        public void Depositar(decimal valor)
        {

            Saldo = Saldo + valor;
        }
           
      
    }
}
