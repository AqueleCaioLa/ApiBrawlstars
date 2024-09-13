using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBrawlstars.Models
{
    [Table("Brawlstars")]
    public class Brawlstar
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nome { get; set; }
        public string? Tipo { get; set; }
        public int Ano { get; set; }
        public string? Foto { get; set; }
        public string? Regiao { get; set; }
        public string? Raridade { get; set; }
        public string? Lane { get; set; }

        [Required]
        public string Status { get; set; }

    }
}
