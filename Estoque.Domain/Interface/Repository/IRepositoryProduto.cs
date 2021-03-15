using Estoque.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Domain.Interface.Repository
{
    public interface IRepositoryProduto : IDisposable
    {
        Task<IEnumerable<Produto>> Obter(Expression<Func<Produto, bool>> expression);
        void Atualizar(Produto obj);
        void Adicionar(Produto obj);
        void Excluir(Produto obj);
        Task<Produto> ObterProdutoPorId(Guid produtoId);
        Task<IEnumerable<Produto>> ObterProdutos();
    }
}
