using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesDeContas.Models
{
    public class ContaEspecial : Conta
    {
        public decimal Limite { get; set; }
        public override void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public override void Sacar(decimal valor)
        {
            decimal saldoDisponivel = Saldo + Limite;
            if (valor <= saldoDisponivel)
                Saldo -= valor;
            else
                Console.WriteLine("Saldo insuficiente.");
        }
    }
}
