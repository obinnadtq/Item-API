using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public class UpdateItemDto
    {
         [Required]        
         public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public decimal Price { get; set; }
    }
}