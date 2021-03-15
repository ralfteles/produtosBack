using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Domain.Entities.Base
{
    public class EntityBase : ValidateEntity
    {
        public Guid Id { get; private set; }
        public DateTime DataDeCadastro { get; private set; }
        public DateTime DataDeAlteracao { get; private set; }
        public bool Lixeira { get; private set; }

        public EntityBase()
        {
            Id = Guid.NewGuid();
            DataDeCadastro = DateTime.Now;
            DataDeAlteracao = DateTime.Now;
        }

        public void EnviarParaLixeira() => Lixeira = true;
        public void RestaurarDaLixeira() => Lixeira = false;
    }
}
