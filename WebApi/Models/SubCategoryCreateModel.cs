using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class SubCategoryCreateModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }
    }
}
