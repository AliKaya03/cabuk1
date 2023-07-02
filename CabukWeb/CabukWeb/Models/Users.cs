using System.ComponentModel.DataAnnotations;

namespace CabukWeb.Models
{
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Adress { get; set; }
        
        public DateTime CreatedDate { get; set; }

        public bool IsActive { get; set; }

        public List<Carts> Carts { get; set; }

        public List<Order> Orders { get; set; }

    }
}
