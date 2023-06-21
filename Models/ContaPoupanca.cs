using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesDeContas.Models
{
    public class ContaPoupanca : Conta
    {
        public decimal TaxaRendimento { get; set; }
        public int DiaAniversario { get; set; }
        public decimal RendimentoAnual { get; set; }

        public override void Depositar(decimal valor)
        {
            base.Depositar(valor);
            CalcularRendimentoAnual();
        }

        public override void Sacar(decimal valor)
        {
            base.Sacar(valor);
            CalcularRendimentoAnual();
        }

        private void CalcularRendimentoAnual()
        {
            decimal rendimento = Saldo * (RendimentoAnual / 100);
            Saldo += rendimento;
        }
    }
}
