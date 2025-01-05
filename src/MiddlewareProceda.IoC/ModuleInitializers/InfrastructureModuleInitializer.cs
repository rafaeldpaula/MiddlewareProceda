using MiddlewareProceda.Domain.Repositories;
using MiddlewareProceda.ORM;
using MiddlewareProceda.ORM.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MiddlewareProceda.IoC.ModuleInitializers;

public class InfrastructureModuleInitializer : IModuleInitializer
{
    public void Initialize(WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<DbContext>(provider => provider.GetRequiredService<DefaultContext>());
        builder.Services.AddScoped<IUserRepository, UserRepository>();
    }
}