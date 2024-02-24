using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Zhang.Models
{
    public class Movie
    {
        [Key] public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public required int CategoryId { get; set;}
        public Category Category { get; set;}
        public required string Title {  get; set;}   
        public required int Year { get; set;}
        public required string Director {  get; set;}
        public required string Rating { get; set;}
        public string? Edited { get; set;}
        public string? Lent { get; set;}
        public string? Note { get; set; }
    }
}
