using System.ComponentModel.DataAnnotations;

namespace CabukWeb.Models
{
    public class Payment
    {
        [Key]

        public int PaymentId { get; set; }
        public string Name { get; set; }
        public string CardNo { get; set; }
        public string ExpirtyDate { get; set; }
        public int CvvNo { get; set; }
        public string Adress { get; set; }

        public List<Order> Orders { get; set; }

    }
}
