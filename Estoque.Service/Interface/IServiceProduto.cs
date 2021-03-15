using Estoque.Domain.Entities;
using Estoque.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Estoque.Service.Interface
{
    public interface IServiceProduto : IDisposable
    {
        Task<IEnumerable<Produto>> ObterProdutos();
        Task<Produto> ObterPorId(Guid id);
        void Atualizar(ProdutoViewModel produtoVm);
        void Adicionar(Produto produto);
        void Excluir(Guid Id);
    }
}
