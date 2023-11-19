
using SıgnalRProject.DataAccess.Extensions;
using SıgnalRProject.Service.Extensions;
using System.Reflection;

namespace SıgnalRProject.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.LoadDataLayerExtension(builder.Configuration);
            builder.Services.LoadServiceLayerExtension();
            builder.Services.AddSignalR();
            builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
			builder.Services.AddCors(opt =>
			{
				opt.AddPolicy("CorsPolicy", builder =>
				{
					builder.AllowAnyHeader()
					.AllowAnyMethod()
					.SetIsOriginAllowed((host) => true)
					.AllowCredentials();
				});
			});

			var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
			app.UseCors("CorsPolicy");
			app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}