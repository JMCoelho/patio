using System.ComponentModel.DataAnnotations;

namespace patio_back.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Token { get; set; }

        public string Refresh {  get; set; }

    }
}
