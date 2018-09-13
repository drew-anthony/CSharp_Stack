using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;
 
namespace RESTauranter.Models
{
    public class REST
    {
        [Key]
        public long restid {get;set;}

        [Required]
        [MinLength(1)]
        [MaxLength(45)]
        public string Name {get; set;}
        [Required]
        [MinLength(2)]
        [MaxLength(45)]

        public string Restaurant {get; set;}
        
        [Required]
        [MinLength(5)]
        [MaxLength(255)]
        public string Review {get; set;}

        [Required]
        [Range(1,5)]
        public int Rate {get; set;}

        [Required]
        public DateTime Visit {get; set;}

    }
}