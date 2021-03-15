using Estoque.Domain.Entities;
using Estoque.Domain.Entities.Base;
using Estoque.Domain.Interface.Repository;
using Estoque.Service.Interface;
using Estoque.Service.Service;
using Microsoft.VisualBasic;
using Moq;
using Moq.AutoMock;
using StructureMap.AutoMocking;
using System;
using Xunit;

namespace Estoque.Teste
{
    public class ProdutoDomainTest
    {
        private Produto _produto = new Produto("Notebook",10,"image.png");

        [Fact(DisplayName = "Adicionar emissor retorna sucesso")]
        [Trait("Categoria", "Produto Trait Test")]
        public void Produto_InformarEmissor_DeveRetornarSucesso()
        {
            //Act
            var produto = _produto;

            //Assert
            Assert.NotNull(produto);
        }
    }
}
