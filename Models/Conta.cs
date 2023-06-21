using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesDeContas.Models
{
    public abstract class Conta
    {
        public int Numero { get; set; }
        public decimal Saldo { get; set; }
        public Cliente? Titular { get; set; }
        public virtual void Depositar(decimal valor)
        {
            Saldo += valor;
        }

        public virtual void Sacar(decimal valor)
        {
            if (valor <= Saldo)
                Saldo -= valor;
            else
                Console.WriteLine("Saldo insuficiente.");
        }

        public void Transferir(decimal valor, Conta contaDestino)
        {
            if (valor <= Saldo)
            {
                Sacar(valor);
                contaDestino.Depositar(valor);
                Console.WriteLine("Transferência realizada com sucesso.");
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para transferência.");
            }
        }
    }
}
