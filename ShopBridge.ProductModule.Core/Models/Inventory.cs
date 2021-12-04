using System;
using System.Collections.Generic;
using System.Text;

namespace ShopBridge.ProductModule.Core.Models
{
    public class Inventory:InventoryData
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
