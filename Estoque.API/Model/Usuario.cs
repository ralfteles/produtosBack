using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estoque.API.Model
{
    public class Usuario : IdentityUser<Guid>
    {
        public int Perfil { get; set; }
    }
}
