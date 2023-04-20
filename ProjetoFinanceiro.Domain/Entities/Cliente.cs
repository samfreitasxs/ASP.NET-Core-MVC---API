using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Entities
{
    public class Cliente
    {
        private int ClienteId { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
    }
}
