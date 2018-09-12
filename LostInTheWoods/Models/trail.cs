using System;
using System.ComponentModel.DataAnnotations;

namespace LostInTheWoods
{
    public class Trail
    {
        [Key]
        public long Id {get;set;}

        [Required]
        public string Name {get; set;}
        [MinLength(5)]

        public string Description {get; set;}

        [Required]
        public double? Length {get; set;}

        [Required]
        public double? Elevation {get; set;}

        [Required]
        public double? Longitude {get; set;}

        [Required]
        public double? Latitude {get; set;}

        public DateTime Created_At {get; set;}

        public DateTime Updated_At {get; set;}

        public Trail()
        {
            Created_At = DateTime.Now;
            Updated_At = DateTime.Now;
        }
    }
}