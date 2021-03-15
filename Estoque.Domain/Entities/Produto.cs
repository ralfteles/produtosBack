using Estoque.Domain.Entities.Base;
using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;

namespace Estoque.Domain.Entities
{
    public class Produto : EntityBase
    {
        public string Nome { get; private set; }
        public double Valor { get; private set; }
        public string Imagem { get; private set; }

        public Produto(string nome, double valor, string imagem)
        {
            Nome = nome;
            Valor = valor;
            Imagem = imagem;

            EstaValido();
        }

        private Produto() {}

        public override bool EstaValido()
        {
            ValidationResult = new ProdutoValidation().Validate(this);
            return ValidationResult.IsValid;
        }


        private class ProdutoValidation : AbstractValidator<Produto>
        {
            public ProdutoValidation()
            {
                RuleFor(c => c.Nome)
                  .NotEmpty()
                  .WithMessage("Informe o nome do produto.");

                RuleFor(c => c.Imagem)
                 .NotEmpty()
                 .WithMessage("Informe a imagem do produto.");

                RuleFor(c => c.Valor)
                .NotEmpty()
                .WithMessage("Informe o valor do produto.");
            }
        }

        public void SetNome(string nome) => Nome = nome;
        public void SetImagem(string imagem) => Imagem = imagem;
        public void SetValor(double valor) => Valor = valor;
    }
}
