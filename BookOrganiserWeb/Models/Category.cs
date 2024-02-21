using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookOrganiserWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [DisplayName("Display Order")]
        [Range(1,100, ErrorMessage ="Display Order must be from 1 to 100")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
