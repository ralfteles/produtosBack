using System;

namespace Estoque.Service.ViewModel
{
    public class ProdutoViewModel
    {
        public Guid ProdutoId { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public string Imagem { get; set; }
    }
}
