namespace Dosti.Api.Extensions
{
    public static class DependentServicesExtensions
    {
        public static IServiceCollection AddDependentServices(this IServiceCollection services)
        {
            _ = services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            _ = services.AddEndpointsApiExplorer();
            _ = services.AddSwaggerGen();

            return services;
        }

    }

}
