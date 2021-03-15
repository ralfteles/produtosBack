using Estoque.Domain.Interface.Repository;
using Estoque.Repository.Repository;
using Estoque.Repository.UnitOfWork;
using Estoque.Service.Interface;
using Estoque.Service.Service;
using FluentValidation.AspNetCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Estoque.API.Configuracao
{
    public class DependecyInjection
    {
        public static void RegistrarServicos(IServiceCollection services)
        {
            services.AddScoped<IRepositoryProduto, RepositoryProduto>();
            services.AddScoped<IServiceProduto, ServiceProduto>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddControllersWithViews()
                .AddFluentValidation(opt =>
                {
                    opt.RegisterValidatorsFromAssembly(Assembly.GetExecutingAssembly());
                });
        }
    }
}
