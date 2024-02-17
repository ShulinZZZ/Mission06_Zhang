using System.ComponentModel.DataAnnotations;

namespace Mission06_Zhang.Models
{
    public class Movies
    {
        [Key] public int MovieId { get; set; }
        public required string category { get; set;}
        public required string title {  get; set;}   
        public required int year { get; set;}
        public required string director {  get; set;}
        public required string rating { get; set;}
        public string? edited { get; set;}
        public string? lent { get; set;}
        public string? notes { get; set; }
    }
}
