using System;
using System.Collections.Generic;
using System.Text;

namespace POO
{
    public class ContaBancaria
    {
        private double saldo;

        public void Depositar(double valorDepositado)
        {
            saldo += valorDepositado;
        }

        public void Sacar(double valorSaldo)
        {
            if (valorSaldo <= saldo)
            {
                saldo -= valorSaldo;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente.");
            }
        }
        public void MostrarSaldo()
        {
            Console.WriteLine($"Saldo atual {saldo}");
        }
    }
}
