﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
