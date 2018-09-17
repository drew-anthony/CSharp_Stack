using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
 
namespace LoginAndRegistration.Models
{
    public class Registration
    {
        [Key]
        public long UserId { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(45)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(45)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")]
        public string Email { get; set; }

        [Required]
        [MinLength(5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [NotMapped]
        [Compare("Password")]
        public string Confirm { get; set; }

        public DateTime Created_At { get; set; }
        public DateTime Updated_At { get; set; }
    }
}