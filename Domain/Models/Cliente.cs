using clean_code_refactor.Domain.Bases;
using System.Text.Json.Serialization;

namespace clean_code_refactor.Domain.Models
{
    public class Cliente : Identificador
    {
        public string? Nome { get; set; }
        public string? Cpf { get; set; }

        [JsonIgnore]
        public ICollection<Reserva> Reservas { get; set; }

    }
}
