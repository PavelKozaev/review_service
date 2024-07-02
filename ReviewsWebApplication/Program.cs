using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Review.Domain;
using Review.Domain.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();        
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("V1", new OpenApiInfo
            {
                Version = "V1",
                Title = "WebAPI",
                Description = "Secret_WebAPI"
            });
        });

        var connectionString = builder.Configuration.GetConnectionString("Review_Database");
        builder.Services.AddDbContext<DataBaseContext>(x => x.UseSqlServer(connectionString));
        builder.Services.AddScoped<IReviewsService, ReviewsService>();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/V1/swagger.json", "Secret_WebAPI");
            });
        }

        app.UseHttpsRedirection();
        app.MapControllers();
        app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        app.Run();
    }
}
