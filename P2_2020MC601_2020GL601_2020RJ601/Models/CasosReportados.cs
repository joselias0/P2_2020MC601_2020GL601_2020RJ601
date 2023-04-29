using System.ComponentModel.DataAnnotations;

namespace P2_2020MC601_2020GL601_2020RJ601.Models
{
    public class CasosReportados
    {
        [Key]
        public int id_caso {get; set;}
        public int? id_departamento { get; set;}
        public int? id_genero { get; set; }
        public string? casosConfirmados { get; set; }
        public string? casosRecuperados { get; set; }
        public string? casosFallecidos { get; set; }
    }
}
