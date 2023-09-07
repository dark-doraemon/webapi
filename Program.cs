using WebAPI.Models;
namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<IRepository, Repository>();


            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

            var app = builder.Build();

            app.MapControllerRoute(
                name: "default",
                pattern : "api/{controller}",
                defaults: new { controller = "Reservation"});

            app.Run();
        }
    }
}