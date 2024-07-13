
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Shipping.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ShippingDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("ShippingDb"));
            });
            var app = builder.Build();

 
            app.UseSwagger();
            app.UseSwaggerUI();


            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
