using ControlesDeContas.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Agencia agencia = new Agencia { Numero = 123 };

        Cliente cliente = new(){ Id = 1, Nome = "João" };

        ContaPoupanca contaPoupanca = new ContaPoupanca
        {
            Numero = 1,
            Titular = cliente,
            TaxaRendimento = 0.5m,
            DiaAniversario = 1,
            RendimentoAnual = 2.5m
        };

        ContaCorrente contaCorrente = new ContaCorrente
        {
            Numero = 2,
            Titular = cliente
        };

        ContaEspecial contaEspecial = new ContaEspecial
        {
            Numero = 3,
            Titular = cliente,
            Limite = 1000
        };

        agencia.InserirConta(contaPoupanca);
        agencia.InserirConta(contaCorrente);
        agencia.InserirConta(contaEspecial);

        cliente.Contas.Add(contaPoupanca);
        cliente.Contas.Add(contaCorrente);
        cliente.Contas.Add(contaEspecial);

        contaPoupanca.Depositar(500);
        contaCorrente.Depositar(1000);
        contaEspecial.Depositar(2000);

        contaPoupanca.Sacar(200);
        contaCorrente.Sacar(1500);
        contaEspecial.Sacar(3000);

        decimal totalSaldos = agencia.CalcularTotalSaldos();
        Console.WriteLine("Total de saldos das contas da agência: " + totalSaldos);
    }
}
