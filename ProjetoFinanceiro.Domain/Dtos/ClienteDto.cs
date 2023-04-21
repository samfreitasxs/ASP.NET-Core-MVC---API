using System;
using ProjetoFinanceiro.Domain.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoFinanceiro.Domain.Dtos
{
    internal class ClienteDto
    {
        private int ClienteId { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }

        public Cliente ConverterParaEntidade()
        {
            return new Cliente
            {
                ClienteId = this.ClienteId,
                Name = this.Name,
                Cpf = this.Cpf
            };
        }
        public static List<Cliente> ConverterParaEntidade(List<ClienteDto> clientesDto)
        {
            List<Cliente> clientes = new List<Cliente>();

            foreach (ClienteDto cliente in clientesDto)
            {
                Cliente entidade = cliente.ConverterParaEntidade();
                clientes.Add(entidade);
            }

            return clientes;
        }
    }
}
