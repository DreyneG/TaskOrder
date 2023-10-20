using System.Security;
using System;
using System.ComponentModel.DataAnnotations;

namespace TaskOrder.Models
{
    public class Categoria
    {
        public int CategoriaId{get;set;}
        [Display(Name = "Nome da Categoria")]
        [Required(ErrorMessage = "Informe o nome da categoria")]
        public String Nome{get; set;}
        public List<Item> Itens{get; set;}
    }
}
