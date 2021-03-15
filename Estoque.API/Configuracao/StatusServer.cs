using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.API.Configuracao
{
    public class StatusServer
    {
        public string mensagem { get; set; }
        public StatusServer(string mensagem)
        {
            this.mensagem = mensagem;
        }
    }
}
