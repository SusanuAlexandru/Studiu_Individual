using System.ComponentModel.DataAnnotations;

namespace AppMagazin.Models
{
    public class Produs
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Imaginea este obligatoriu!")]
        public string? ImagineURL { get; set; }
        [Required(ErrorMessage ="Numele este obligatoriu!")]
        public string? Nume { get; set; }
        public string? Descriere { get; set; }
        [Range(0, double.MaxValue, ErrorMessage ="Pretul trebue sa fie o valoare pozitiva!")]
        public decimal Pret {  get; set; }
        [Range(0, int.MaxValue, ErrorMessage ="Stocul trebuie sa fie o valoare pozitiva!")]
        public int Stoc { get; set; }
    }
}
