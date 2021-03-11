using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Zad2.Models
{
    public class Address
    {
        [Display(Name = "Twoja ulubiona ulica")]
        [Required]
        public string Street { get; set; }

        [StringLength(60, MinimumLength = 3, ErrorMessage = "Min 3 znaki"), Required]
        public string ZipCode { get; set; }

        [Required(ErrorMessage ="Pole jest obowi¹zkowe")]
        public string City { get; set; }
        public int Number { get; set; }

    }
}
