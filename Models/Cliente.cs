using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlesDeContas.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Email { get; set; }
        public int AnoNascimento { get; set; }  
        public string? Nome { get; set; }
        public string? Cpf { get; set; } 

        public List<Conta> Contas { get; set; }

        public Cliente()
        {
            Contas = new List<Conta>();
        } 
    }

}

