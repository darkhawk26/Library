using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Author cannot exceed 50 characters.")]
        public string Author { get; set; }

        [Range(1000, 9999, ErrorMessage = "Year must be a valid year.")]
        public int YearPublished { get; set; }
    }
}
