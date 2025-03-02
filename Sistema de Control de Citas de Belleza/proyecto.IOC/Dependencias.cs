using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using proyecto.Infrastructure.DBContext;
using Microsoft.EntityFrameworkCore;
using proyecto.Application.Implementacion;
using proyecto.Application.Interfaces;
using Proyecto.Infrastructure.Implementacion;
using Proyecto.Infrastructure.Interfaces;
using System.Runtime.CompilerServices;



namespace proyecto.IOC
{
    public static class Dependencias
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<SistemaCitasBellezaContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("CadenaSQL"));

            });
        }
    }
}
