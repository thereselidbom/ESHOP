using System.ComponentModel.DataAnnotations;

namespace EshopMVC.Models
{
    public class SubCategory
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int CategoryId { get; set; }

        public virtual Category? Category { get; set; }

        public virtual ICollection<Product>? Products { get; set; }
    }
}
