using System.ComponentModel.DataAnnotations;

namespace patio_back.Model
{
    public class Caminhao
    {
        [Key]
        public int Id { get; set; }
        public string Placa { get; set; }
    }
}
