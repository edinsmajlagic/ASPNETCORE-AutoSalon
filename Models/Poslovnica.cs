using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoSalon.Models
{
    public class Poslovnica
    {
        [Key]
        public int PoslovnicaID { get; set; }
        [Required(ErrorMessage = "Grad je obavezno polje")]
        [DisplayName("Grad")]
        public int GradID { get; set; }
        [ForeignKey("GradID")]
        public Grad Grad { get; set; }

        [Required(ErrorMessage = "Naziv je obavezno polje")]
        [MinLength(5, ErrorMessage = "Unos je prekratak")]
        [MaxLength(30, ErrorMessage = "Unos je predug")]
        [RegularExpression(@"^[A-Ža-ž 0-9]+$", ErrorMessage = "Format nije validan. " +
             "Dozvoljeni format je : MojAuto Mostar, MojAuto Sarajevo II")]
        public string Naziv { get; set; }

        [Required(ErrorMessage = "Adresa je obavezno polje")]
        [MinLength(5, ErrorMessage = "Unos je prekratak")]
        [MaxLength(50, ErrorMessage = "Unos je predug")]
        [RegularExpression(@"^[A-Ža-ž 0-9\.]+$", ErrorMessage = "Format nije validan. " +
            "Dozvoljeni format je : Maršala Tita 26., Maršala Tita 26")]
        public string Adresa { get; set; }

        [MinLength(5, ErrorMessage = "Unos je prekratak")]
        [MaxLength(50, ErrorMessage = "Unos je predug")]
        [RegularExpression(@"^[A-Ža-ž 0-9\+]+$", ErrorMessage = "Format nije validan. " +
           "Dozvoljeni format je : 0038765304022,+387 65 304 022")]
        public string KontaktTelefon { get; set; }

        public string SlikaURL { get; set; }
    }
}
