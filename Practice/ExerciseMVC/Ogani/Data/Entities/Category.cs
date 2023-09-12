using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ogani.Data.Entities
{
    [Table("tbl_categories")]
    public class Category
    {
        [Key]
        public Guid CategoryID{get; set;}
        [StringLength(150,ErrorMessage ="Category name is too long. Must be less than 150 characters")]
        public string CategoryName { get; set;}

        [StringLength(500, ErrorMessage = "Category name is too long. Must be less than 500 characters")]

        public string CategoryDescrtiption { get; set; }
    }
}
