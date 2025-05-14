using clean_code_refactor.Domain.Bases;

namespace clean_code_refactor.Domain.Models
{
    public class Reserva : Identificador
    {
        public StatusReservaEnum Status { get; set; }
        public int QuantidadePessoas { get; set; }
        public int Diarias { get; set; }
        public decimal ValorTotal { get; set; }
        public TipoQuartoEnum TipoQuarto { get; set; }
        public DateTime DataReserva { get; set; } = DateTime.Now;
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int ClienteId { get; set; }

        public Cliente Cliente { get; set; }
    }
}
