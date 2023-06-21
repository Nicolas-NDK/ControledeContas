using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesDeContas.Models
{
    public class Agencia
    {
        public int Numero { get; set; }
        public List<Conta> Contas { get; set; }

        public Agencia()
        {
            Contas = new List<Conta>();
        }

        public void InserirConta(Conta conta)
        {
            Contas.Add(conta);
            Console.WriteLine("Conta inserida com sucesso.");
        }

        public decimal CalcularTotalSaldos()
        {
            decimal total = 0;
            foreach (Conta conta in Contas)
            {
                total += conta.Saldo;
            }
            return total;
        }

    }
}
