using System.ComponentModel.DataAnnotations;

namespace newbooksproject.DTOs
{
    public class BookDTOs
    {
        
            [Required]
            public string Title { get; set; }
            public int yearOfPublication { get; set; }
        
    }
}
