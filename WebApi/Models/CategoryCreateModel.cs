using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class CategoryCreateModel
    {

        [Required]
        public string? Name { get; set; }
    }
}
