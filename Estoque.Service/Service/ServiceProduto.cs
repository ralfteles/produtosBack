using Estoque.Domain.Entities;
using Estoque.Domain.Interface.Repository;
using Estoque.Service.Interface;
using Estoque.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Estoque.Service.Service
{
    public class ServiceProduto : IServiceProduto
    {
        private readonly IRepositoryProduto _repositoryProduto;
        private readonly IUnitOfWork _unitOfWork;
        public ServiceProduto(IRepositoryProduto repositoryProduto,
                              IUnitOfWork unitOfWork)
        {
            _repositoryProduto = repositoryProduto;
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Produto>> ObterProdutos()
        {
            return await _repositoryProduto.ObterProdutos();
        }

        public async Task<Produto> ObterPorId(Guid id)
        {
            return await _repositoryProduto.ObterProdutoPorId(id);
        }

        public void Atualizar(ProdutoViewModel produtoVm)
        {
            var produto = _repositoryProduto.ObterProdutoPorId(produtoVm.ProdutoId).Result;

            produto.SetImagem(produtoVm.Imagem);
            produto.SetNome(produtoVm.Nome);
            produto.SetValor(produtoVm.Valor);

            _repositoryProduto.Atualizar(produto);
            _unitOfWork.Commit();
        }

        public void Adicionar(Produto produto)
        {
            _repositoryProduto.Adicionar(produto);
            _unitOfWork.Commit();
        }

        public void Excluir(Guid id)
        {
            var produto = _repositoryProduto.ObterProdutoPorId(id).Result;
            produto.EnviarParaLixeira();

            _repositoryProduto.Atualizar(produto);
            _unitOfWork.Commit();
        }

        public void Dispose()
        {
            _repositoryProduto?.Dispose();
        }
    }
}
