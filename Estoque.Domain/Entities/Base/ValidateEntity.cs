using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Estoque.Domain.Entities.Base
{
    public class ValidateEntity
    {
        [NotMapped]
        public ValidationResult ValidationResult { get; set; }

        public virtual bool EstaValido()
        {
            throw new NotImplementedException();
        }
    }
}
