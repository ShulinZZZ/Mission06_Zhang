using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Zhang.Models
{
    public class Movie
    {
        [Key] public required int MovieId { get; set; }

        [ForeignKey("CategoryId")]//set the foreign key relationship between tables
        public int? CategoryId { get; set; }

        public Category? CategoryName { get; set; }
        public required string Title { get; set; } [Required(ErrorMessage = "Sorry, you need to input the title of the movie")]

        public required int Year { get; set; }[Required(ErrorMessage = "Sorry, you need to input the year of the movie")]

        public string? Director { get; set; }

        public string? Rating { get; set; }

        public required int Edited { get; set; }[Required(ErrorMessage = "Sorry, you need to input whether or not the movie is edited")]

        public string? LentTo { get; set; }
        public required int CopiedToPlex { get; set; }[Required(ErrorMessage = "Sorry, you need to input the number copied to plex of the movie")]

        public string? Notes { get; set; }
    }
}
