using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Längdskidor.Models
{
    public class skidor
    {
        [Range(1, 187, ErrorMessage = "Length must be between 1 and 187")]
        [Required(ErrorMessage = "The Length is required")]
        [Display(Prompt = "Ditt länged")]
        public float Length { get; set; }

        [Range(8, 200)]
        public int Age { get; set; }
        public bool Barn04 { get; set; } 
        public bool Barn58 { get; set; }
        public bool Agemor8 { get; set; }
        public bool IsKlass { get; set; }
        public float Skidlangd { get; set; }
        public string Info { get; set; }
    }
}
