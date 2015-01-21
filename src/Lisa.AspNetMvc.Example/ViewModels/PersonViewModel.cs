using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Lisa.AspNetMvc.Example
{
    public class PersonViewModel
    {
        [Display(Name = "Voornaam:")]
        [Required(ErrorMessage = "Arthur wil dat je dit weet.")]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string FavoriteColor { get; set; }

        public IEnumerable<SelectListItem> Colors
        {
            get
            {
                return new SelectListItem[]
                {
                    new SelectListItem
                    {
                        Text = "rood",
                        Value = "red"
                    },

                    new SelectListItem
                    {
                        Text = "geel",
                        Value = "yellow"
                    },

                    new SelectListItem
                    {
                        Text = "blauw",
                        Value = "blue"
                    }
                };
            }
        }
    }
}