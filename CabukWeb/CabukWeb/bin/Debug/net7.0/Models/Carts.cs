using System.ComponentModel.DataAnnotations;

namespace CabukWeb.Models
{
    public class Carts
    {
        [Key]

        public int CartId { get; set; }

        public int ProductId { get; set; }

        public Products Products { get; set; }

        public int UserId { get; set; }

        public Users Users { get; set; }

        public int Quantity { get; set; }
    }
}
