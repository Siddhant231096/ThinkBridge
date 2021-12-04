using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ShopBridge.ProductModule.Data.Models
{
    public class InventoryEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        [StringLength(128)]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "Money")]
        [Required]  
        public decimal Price { get; set; }
        [StringLength(128)]
        public string ProductType { get; set; }
        public string Description { get; set; }
    }
}
