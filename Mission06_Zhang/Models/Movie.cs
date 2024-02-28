using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Zhang.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        public int? CategoryId { get; set; }

        public Category? CategoryName { get; set; }


        [Required(ErrorMessage = "Sorry, you need to input the title of the movie")]

        public string Title { get; set; } 


        [Required]
        [Range(0, 2024, ErrorMessage = "Sorry, you need to input the year of the movie and it needs to be earlier than 2024")]
        public int Year { get; set; }

        public string? Director { get; set; }


        [Required(ErrorMessage = "Sorry, you need to input the rating of the movie")]
        public string Rating { get; set; }


        [Required(ErrorMessage = "Sorry, you need to input whether or not the movie is edited")]
        public bool Edited { get; set; }


        public string? LentTo { get; set; }


        [Required(ErrorMessage = "Sorry, you need to input the number copied to plex of the movie")]
        public bool CopiedToPlex { get; set; }


        [MaxLength(25, ErrorMessage = "Sorry, you need to input the number copied to plex of the movie")]
        public string? Notes { get; set; }
    }
}
