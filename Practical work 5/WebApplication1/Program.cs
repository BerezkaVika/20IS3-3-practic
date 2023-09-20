using BusinessLogic.Interfaces;
using BusinessLogic.Services;
using DataAccess.Models;
using DataAccess.Wrapper;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            // Server=(LocalDB)\\MSSQLLocalDB;Database=Online_shop;Integrated Security = true;
            builder.Services.AddDbContext<Online_shopContext>(
                          optionsAction: options => options.UseSqlServer(
                              connectionString: "Server=(LocalDB)\\MSSQLLocalDB;Database=Online_shop;Integrated Security = true;"));

            builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            builder.Services.AddScoped<IUserService, UserService>();


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}