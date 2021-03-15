using AutoMapper;
using Estoque.Domain.Entities;
using Estoque.Service.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.API.Configuracao
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Produto, ProdutoViewModel>()
                 .ForMember(Model => Model.ProdutoId, m => m.MapFrom(entidade => entidade.Id))
                 .ForMember(Model => Model.Nome, m => m.MapFrom(entidade => entidade.Nome))
                 .ForMember(Model => Model.Imagem, m => m.MapFrom(entidade => entidade.Imagem))
                 .ForMember(Model => Model.Valor, m => m.MapFrom(entidade => entidade.Valor));


            CreateMap<ProdutoViewModel, Produto>()
                      .ConstructUsing(produtoVm => new Produto(produtoVm.Nome, produtoVm.Valor, produtoVm.Imagem));
        }
    }
}
