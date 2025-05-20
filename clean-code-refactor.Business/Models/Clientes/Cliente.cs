using clean_code_refactor.Business.Models.Reservas;
using clean_code_refactor.Domain.Bases;
using System.Text.Json.Serialization;

namespace clean_code_refactor.Business.Models.Clientes
{
    public class Cliente : Identificador
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }

        [JsonIgnore]
        public ICollection<Reserva> Reservas { get; set; }

    }
}
