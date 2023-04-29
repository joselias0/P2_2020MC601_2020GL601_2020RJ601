using System.ComponentModel.DataAnnotations;

namespace P2_2020MC601_2020GL601_2020RJ601.Models
{
    public class Generos
    {
        [Key]
        public int id_genero { get; set; }
        public string? nombre_genero { get; set; }
    }
}
