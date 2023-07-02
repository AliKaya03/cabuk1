using System.ComponentModel.DataAnnotations;

namespace CabukWeb.Models
{
    public class Categories
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoriesName{ get; set; }
        
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }

        public List<Products> Products { get; set; }
        
    }
}
