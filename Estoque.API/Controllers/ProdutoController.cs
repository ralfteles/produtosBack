using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Estoque.API.Configuracao;
using Estoque.Domain.Entities;
using Estoque.Service.Interface;
using Estoque.Service.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Estoque.API.Controllers
{
    [Route("api/produto")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapper _mapper;
        public ProdutoController(IServiceProduto serviceProduto, IMapper mapper)
        {
            _serviceProduto = serviceProduto;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoViewModel>> ObterProdutos()
        {
            var produtos = await _serviceProduto.ObterProdutos();
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(produtos);
        }

        [HttpGet("{id}")]
        public async Task<ProdutoViewModel> ObterPorId(Guid id)
        {
            var produto = await _serviceProduto.ObterPorId(id);
            return _mapper.Map<ProdutoViewModel>(produto);
        }


        [HttpPost]
        public IActionResult Adicionar(ProdutoViewModel produtoVm)
        {
            try
            {
                var produto = _mapper.Map<Produto>(produtoVm);

                if (!produto.ValidationResult.IsValid)
                    return BadRequest(new StatusServer(produto.ValidationResult.Errors[0].ErrorMessage));

                _serviceProduto.Adicionar(produto);
                return Ok(new StatusServer($"{produtoVm.Nome} cadastrado com sucesso!"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Atualizar(ProdutoViewModel produtoVm)
        {
            try
            {
                _serviceProduto.Atualizar(produtoVm);
                return Ok(new StatusServer($"{produtoVm.Nome} atualizado com sucesso!"));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete]
        public ActionResult RemoverEscola(Guid id)
        {
            try
            {
                _serviceProduto.Excluir(id);
                return Ok("Produto removido com sucesso!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
