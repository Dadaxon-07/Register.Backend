using LinqToDB.Mapping;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Register.Backend.Model
{
    public class User
    {
        [Identity]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set;}
        [PasswordPropertyText]
        [MinLength(8)]
        public string Password { get; set; }

    }
}
