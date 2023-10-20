using System;
using TaskOrder.Models;

namespace TaskOrder.Repositories.Interfaces
{
    public interface IItemRepository
    {
        
            public IEnumerable<Item> Itens { get; }
            public IEnumerable<Item> ItensEmDestaque { get; }
            public Item GetItemById(int itemId);
        
    }
}