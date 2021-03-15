using Estoque.Domain.Entities;
using Estoque.Domain.Interface.Repository;
using Estoque.Repository.Repository;
using Estoque.Service.Interface;
using Estoque.Service.Service;
using Moq;
using Moq.AutoMock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Estoque.Teste
{
    //public class ProdutoServiceTest
    //{
    //    [Fact(DisplayName = "Adicionar produto de retornar sucesso")]
    //    [Trait("Categoria", "Produto Service Trait Test")]
    //    public void Produto_AdcionarNovoProduto_Sucesso()
    //    {
    //        //Arrange
    //        var produto = new Produto("Fulado", DateTime.Now, null, null,
    //                                  "123123", "1123", Status.Em_Aberto,
    //                                  Setor.Borracha, "descrição", 2,
    //                                  "responsavel", "obs", "cliente",
    //                                  TipoProduto.GARANTIA);

    //        var mocker = new AutoMocker();
    //        var serviceProduto = mocker.CreateInstance<ServiceProduto>();

    //        //act
    //        serviceProduto.Adicionar(produto);

    //        //Assert
    //        mocker.GetMock<IRepositoryProduto>().Verify(x => x.Adicionar(produto), Times.Once);
    //    }

    //    [Fact(DisplayName = "Atualizar produto de retornar sucesso")]
    //    [Trait("Categoria", "Produto Service Trait Test")]
    //    public void Produto_AtualizarProduto_Sucesso()
    //    {
    //        //Arrange
    //        var produto = new Produto("Fulado", DateTime.Now, null, null,
    //                                  "123123", "1123", Status.Em_Aberto,
    //                                  Setor.Borracha, "descrição", 2,
    //                                  "responsavel", "obs", "cliente",
    //                                  TipoProduto.GARANTIA);

    //        var mocker = new AutoMocker();
    //        var serviceProduto = mocker.CreateInstance<ServiceProduto>();

    //        //act
    //        serviceProduto.Atualizar(produto);

    //        //Assert
    //        mocker.GetMock<IRepositoryProduto>().Verify(x => x.Atualizar(produto), Times.Once);
    //    }

    //    [Fact(DisplayName = "Retornar uma lista de produtos")]
    //    [Trait("Categoria", "Produto Service Trait Test")]
    //    public async Task Produto_RetrornarListaDeProdutos_Sucesso()
    //    {
    //        //Arrange
          

    //        var produto1 = new Produto("Fulado", DateTime.Now, null, null,
    //                                   "123123", "1123", Status.Em_Aberto,
    //                                   Setor.Borracha, "descrição", 2,
    //                                   "responsavel", "obs", "cliente",
    //                                   TipoProduto.GARANTIA);


    //        var produto2 = new Produto("Fulado", DateTime.Now, null, null,
    //                                   "123123", "1123", Status.Em_Aberto,
    //                                   Setor.Borracha, "descrição", 2,
    //                                   "responsavel", "obs", "cliente",
    //                                   TipoProduto.GARANTIA);

    //        var produto3 = new Produto("Fulado", DateTime.Now, null, null,
    //                                   "123123", "1123", Status.Em_Aberto,
    //                                   Setor.Borracha, "descrição", 2,
    //                                   "responsavel", "obs", "cliente",
    //                                   TipoProduto.GARANTIA);

    //        var produtos = new List<Produto>();
    //        produtos.Add(produto1);
    //        produtos.Add(produto2);
    //        produtos.Add(produto3);

    //        var repositorioProduto = new Mock<IRepositoryProduto>();
    //        var repositorioHistorico = new Mock<IRepositoryHistorico>();


    //        //Arrange
    //        repositorioProduto.Setup(p => p.ObterProdutos())
    //           .ReturnsAsync(produtos);

    //        var serviceProduto = new ServiceProduto(repositorioProduto.Object, repositorioHistorico.Object, null);

    //        //Act
    //        var result = await serviceProduto.ObterProdutos();

    //        //Assert
    //        Assert.True(result.Count() > 0);


    //    }
    //}
}
