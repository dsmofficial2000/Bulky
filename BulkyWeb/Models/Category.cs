using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BulkyWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("Category Name")] //show the name ONLY on UI
        public string Name { get; set; }
        [DisplayName("Display Order")] //show the name ONLY on UI
        public int DisplayOrder { get; set; }
    }
}
