using System;
using System.Collections.Generic;
using System.Text;

namespace Estoque.Domain.Entities.Base
{
    public class DomainException : Exception
    {
        public DomainException(string mensagem)
            : base(mensagem)
        {

        }
    }
}
