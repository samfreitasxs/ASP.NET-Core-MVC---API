using ProjetoFinanceiro.Domain.Dtos;
using System.Collections.Generic;

namespace ProjetoFinanceiro.Domain.Entities
{
    public class Cliente
    {
        private int ClienteId { get; set; }
        public string Name { get; set; }
        public string Cpf { get; set; }
        public ClienteDto ConverterParaDto()
        {
            return new ClienteDto
            {
                ClienteId = this.ClienteId,
                Name = this.Name,
                Cpf = this.Cpf
            };
        }

        public static List<ClienteDto> ConverterParaDto(List<Cliente> clientes)
        {
            List<ClienteDto> clientesDto = new List<ClienteDto>();

            foreach (Cliente cliente in clientes)
            {
                ClienteDto dto = cliente.ConverterParaDto();
                clientesDto.Add(dto);
            }

            return clientesDto;
        }
    }
}
    