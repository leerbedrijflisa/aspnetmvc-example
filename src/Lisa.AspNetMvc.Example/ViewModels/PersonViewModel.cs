using System.ComponentModel.DataAnnotations;

namespace Lisa.AspNetMvc.Example
{
    public class PersonViewModel
    {
        [Display(Name = "Voornaam:")]
        [Required(ErrorMessage = "Arthur wil dat je dit weet.")]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}