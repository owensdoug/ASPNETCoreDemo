using System;
using System.ComponentModel.DataAnnotations;
using ASPNETCoreDemo.Data;

namespace ASPNETCoreDemo.Models
{
    public class Product: IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string Description { get; set; }

    }
}
