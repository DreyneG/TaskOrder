using System;
using Microsoft.EntityFrameworkCore;
using TaskOrder.Context;
using TaskOrder.Models;
using TaskOrder.Repositories.Interfaces;

namespace TaskOrder.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _context;
        public ItemRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Item> Itens => _context.Itens.Include(c =>c.Categoria);
        public IEnumerable<Item> ItensEmDestaque => _context.Itens.Where(m => m.Destaque).Include(c => c.Categoria);

        
        public Item GetItemById(int ItemId)
        {
            return _context.Itens.FirstOrDefault(m => m.ItemId == ItemId);
        }
    }
}
