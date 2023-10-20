using System;
using Microsoft.AspNetCore.Mvc;
using TaskOrder.Models;

namespace TaskOrder.ViewModel
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Itens { get; set; }
        public string CategoriaAtual { get; set; }
    }
}
