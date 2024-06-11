using System.ComponentModel.DataAnnotations;

namespace patio_back.Model
{
    public class Movimentacao
    {

        [Key]
        public int Id { get; set; }
        public int AgendamentoId { get; set; }
        public int CaminhaoId { get; set; }
        public DateTime Entrada { get; set; }
        public DateTime EntradaFabrica { get; set; }
        public DateTime EntradaCarregamento { get; set; }
        public DateTime SaidaCarregamento { get; set; }
        public DateTime SaidaFabrica { get; set; }
        public DateTime Saida { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
