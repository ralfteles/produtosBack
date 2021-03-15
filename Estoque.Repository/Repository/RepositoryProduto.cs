using Estoque.Domain.Entities;
using Estoque.Domain.Interface.Repository;
using Estoque.Repository.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Estoque.Repository.Repository
{
    public class RepositoryProduto : IRepositoryProduto
    {
        private readonly ProdutoContext _produtoContext;

        public RepositoryProduto(ProdutoContext produtoContext)
        {
            _produtoContext = produtoContext;
        }

        public async Task<IEnumerable<Produto>> ObterProdutos()
        {
            return await _produtoContext.Produto.Where(p=>!p.Lixeira).ToListAsync();
        }

        public async Task<Produto> ObterProdutoPorId(Guid produtoId)
        {
            return await _produtoContext.Produto
                .FirstOrDefaultAsync(x => x.Id == produtoId);
        }

        public void Adicionar(Produto obj)
        {
            _produtoContext.Produto.Add(obj);
        }

        public void Atualizar(Produto obj)
        {
            _produtoContext.Produto.Update(obj).State = EntityState.Modified;
        }

        public void Excluir(Produto obj)
        {
            _produtoContext.Produto.Remove(obj);
        }

        public async Task<IEnumerable<Produto>> Obter(Expression<Func<Produto, bool>> expression)
        {
            return await _produtoContext.Produto.Where(x => !x.Lixeira).ToListAsync();
        }

        public async Task<Produto> ObterPorId(Guid Id)
        {
            return await _produtoContext.Produto.FirstOrDefaultAsync(x => x.Id == Id && !x.Lixeira);
        }

        public void Dispose()
        {
            _produtoContext?.Dispose();
        }
    }
}
