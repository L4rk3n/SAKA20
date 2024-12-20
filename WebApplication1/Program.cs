using SAKA20_Common.Repositories;
using SAKA20_BLL.Entities;
using SAKA20_DB;
using SAKA20_API.Services;


namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();

            // Add services to the container.
            builder.Services.AddScoped<DataContext>();
            builder.Services.AddScoped<TokenService>();
            builder.Services.AddScoped<IUtilisateurRepository<SAKA20_BLL.Entities.Utilisateur,int,string>, SAKA20_BLL.Services.UtilisateurService>();
            builder.Services.AddScoped<IVinRepository<SAKA20_BLL.Entities.Vin, int>, SAKA20_BLL.Services.VinService>();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
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
            app.UseCors(o => o.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
