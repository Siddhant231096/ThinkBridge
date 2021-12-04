using ShopBridge.ProductModule.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopBridge.ProductModule.Core.Services
{
    public interface IInventoryService
    {
        Task<IList<Inventory>> GetAllInventory();
        Task<Inventory> GetById(Guid id);
        Task<ValidationResult> AddItemInInventory(InventoryData inventory);
        Task<ValidationResult> UpdateItemInInventory(Guid id,InventoryData inventory);
        Task<ValidationResult> RemoveItemById(Guid id);
    }
}
