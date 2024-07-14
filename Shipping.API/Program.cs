
using ApplicationCore.Interfaces.Repository;
using ApplicationCore.Interfaces.Service;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.Service;
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
            builder.Services.AddScoped<IShipperRepository, ShipperRepository>();
            builder.Services.AddScoped<IShipperService, ShipperService>();
            builder.Services.AddDbContext<ShippingDbContext>(option =>
            {
                option.UseSqlServer(builder.Configuration.GetConnectionString("ShippingDb"));
            });
            builder.Services.AddAutoMapper(typeof(Program));
            var app = builder.Build();

 
            app.UseSwagger();
            app.UseSwaggerUI();


            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
