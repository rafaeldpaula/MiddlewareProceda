using Microsoft.AspNetCore.Builder;

namespace MiddlewareProceda.IoC;

public interface IModuleInitializer
{
    void Initialize(WebApplicationBuilder builder);
}
