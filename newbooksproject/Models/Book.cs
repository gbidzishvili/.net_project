using System.ComponentModel.DataAnnotations;

namespace final_project.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublishYear { get; set; }
    }
}
