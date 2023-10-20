using System;
using Microsoft.AspNetCore.Mvc;
using TaskOrder.Models;
using TaskOrder.Repositories.Interfaces;
using TaskOrder.ViewModel;

namespace TaskOrder.Controllers
{
    public class CarrinhoController : Controller
    {
        private readonly Carrinho _carrinho;
        private readonly IItemRepository _itemRepository;
        public CarrinhoController(Carrinho carrinho, IItemRepository itemRepository)
        {
            _carrinho = carrinho;
            _itemRepository = itemRepository;
        }
        public IActionResult Index()
        {
            var itens = _carrinho.GetCarrinhoCompraItems();
            _carrinho.CarrinhoItens = itens;
            var carrinhoVM = new CarrinhoViewModel
            {
                Carrinho = _carrinho,
                CarrinhoTotal = _carrinho.GetCarrinhoCompraTotal()
            };
            return View(carrinhoVM);
        }
        public IActionResult AdicionarItemNoCarrinhoCompra(int itemId)
        {
            var itemSelecionado = _itemRepository.Itens.FirstOrDefault(l => l.ItemId == itemId);
            if (itemSelecionado != null)
            {
                _carrinho.AdicionarItemCarrinho(itemSelecionado);
            }
            return RedirectToAction("Index");
        }
        public IActionResult RemoverCarrinho(int itemId)
        {
            var itemSelecionado = _itemRepository.Itens.FirstOrDefault(l => l.ItemId == itemId);
            if (itemSelecionado != null)
            {
                _carrinho.RemoverItemDoCarrinhoCompra(itemSelecionado);
            }
            return RedirectToAction("Index");
        }
    }
}
