using System;
using Microsoft.AspNetCore.Mvc;
using TaskOrder.Repositories.Interfaces;

namespace TaskOrder.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoriaMenu(ICategoriaRepository categoriaRespository)
        {
            _categoriaRepository = categoriaRespository;
        }
        public IViewComponentResult Invoke()
        {
            var categoria = _categoriaRepository.Categorias.OrderBy(c => c.Nome);

            return View(categoria);
        }
    }
}
