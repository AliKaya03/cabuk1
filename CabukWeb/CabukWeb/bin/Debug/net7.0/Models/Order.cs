using System.ComponentModel.DataAnnotations;

namespace CabukWeb.Models
{
    public class Order
    {
        [Key]

        public int OrderDetailsId { get; set; }

        public int OrderNo { get; set; }

        public int ProductId { get; set; }

        public Products Products { get; set; }

        public int Quantity { get; set; }

        public int UserId { get; set; }

        public Users Users { get; set; }

        public int Status { get; set; }

        public int PaymentId { get; set; }

        public Payment Payment { get; set; }

        public DateTime OrderDate { get; set; }


    }
}
