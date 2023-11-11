using Application.Services;
using Domain.Interfaces.Repositories;
using Domain.Interfaces.Services;
using Infrastructure;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;

namespace API.IoC
{
    public static class ServicesExtension
    {
        public static void AddServicesSdk(this IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<ProdutoDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IProdutoService, ProdutoService>();

        }
    }
}
