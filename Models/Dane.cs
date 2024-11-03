using System.ComponentModel.DataAnnotations;

namespace ObsForm.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podać imię.")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podać email.")]
        [EmailAddress(ErrorMessage = "Proszę podać poprawny adres email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podać temat.")]
        public string Temat { get; set; }

        [Required(ErrorMessage = "Proszę podać treść wiadomości.")]
        [StringLength(500, MinimumLength = 10, ErrorMessage = "Treść musi mieć od 10 do 500 znaków.")]
        public string Tresc { get; set; }
    }
}