using ProjetoFinanceiro.Domain.Dtos;

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
    }
}
    