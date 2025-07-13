using Microsoft.EntityFrameworkCore;
using NutritionAssessment.Dal;
using NutritionAssessment.Service;
using NutritionAssessment.Service.Interfaces;

namespace NutritionAssessment.WebApi.Extensions;

public static class StartUpExtensions
{
    public static IServiceCollection ConfigureMessenger(
        this IServiceCollection services,
        ConfigurationManager configuration)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAll",
                builder =>
                {
                    builder
                           .AllowAnyMethod()
                           .AllowAnyHeader()
                           .AllowCredentials();
                });
        });
        services.AddControllers();
        services.AddSwaggerGen();

        services.AddScoped<IQuicklyTestService, QuicklyTestService>();

        services.AddDbContext<NutritionAssessmentContext>(x => x.UseNpgsql(
            configuration.GetConnectionString(nameof(NutritionAssessmentContext)),
            x => x.MigrationsAssembly($"{nameof(NutritionAssessment)}.{nameof(NutritionAssessment.Dal)}")));

        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

        return services;
    }
}
