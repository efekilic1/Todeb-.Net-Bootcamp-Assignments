using System.ComponentModel.DataAnnotations;

namespace Models.Entities
{
    public class User
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public UserRole Role { get; set; }
        public UserPassword Password { get; set; }

    }
}
