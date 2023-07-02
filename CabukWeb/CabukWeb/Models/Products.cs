using System.ComponentModel.DataAnnotations;

namespace CabukWeb.Models
{
    public class Products
    {
        [Key]

        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }

        public int CategoryId { get; set; }

        public Categories categories { get; set; } 


        public List<Carts> Carts { get; set; }

        public List<Order> Orders { get; set; }
    }
}
