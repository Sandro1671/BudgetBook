using Microsoft.EntityFrameworkCore;

namespace Haushaltsbuch
{
    public static class Configurator
    {
        public static async Task ConfigureDatabaseAsync(BudgetBookContext context)
        {
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();

        }
        public static WebApplication ConfigureServices(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddLogging();
            builder.Services.AddDbContext<BudgetBookContext>(options =>
            options.UseNpgsql(builder.Configuration.GetConnectionString("BudgetBookContext")));
            var app = builder.Build();
            return app;
        }
        public static WebApplication ConfigureApp(WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            return app;
        }
    }
}
