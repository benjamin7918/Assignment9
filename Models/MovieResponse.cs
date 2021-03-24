using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Assignment3.Models
{
    public class MovieResponse
    {
        //This is where I made certain fields required. I also added an error message. I also made the notes have a 25 character limit.

        [Required(ErrorMessage ="This field is required.")]
        public string Category { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public int Year { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Director { get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25, ErrorMessage ="Notes can only have 25 characters.")]
        public string Notes { get; set; }
    }
}
