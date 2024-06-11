using System.ComponentModel.DataAnnotations;

namespace patio_back.Model
{
    public class Agendamento
    {
        public int Id { get; set; }

        public int UserId {  get; set; }

        public int CaminhaoId {  get; set; }

        public DateTime data {  get; set; }

        public int Status { get; set; }
    }
}
