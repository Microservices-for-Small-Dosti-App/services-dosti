using Dosti.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Dosti.Api.Extensions;

public static class DependentServicesExtensions
{
    public static IServiceCollection AddDependentServices(this IServiceCollection services)
    {
        _ = services.AddControllers();

        var configuration = services.BuildServiceProvider().GetService<IConfiguration>();

        _ = services.AddDbContext<DostiDbContext>(options =>
        {
            _ = options.UseSqlServer(configuration?.GetConnectionString(ConnectionStrings.DefaultConnection));
        });

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        _ = services.AddEndpointsApiExplorer();
        _ = services.AddSwaggerGen();

        return services;
    }

}
