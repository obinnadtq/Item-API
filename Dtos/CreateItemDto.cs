using System;
using System.ComponentModel.DataAnnotations;

namespace Catalog.Dtos
{
    public class CreateItemDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public decimal Price { get; set; }
    }
}