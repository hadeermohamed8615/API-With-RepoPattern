

using CleanCode.BL.Mangers;
using CleanCode.DAL.Data.Context;
using CleanCode.DAL.Repo;
using Microsoft.EntityFrameworkCore;

namespace CleanCode.APIs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string txt = "hi";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<CompanyContext>(o=>
            o.UseSqlServer(builder.Configuration.GetConnectionString("APID2Con")));



            builder.Services.AddCors(options =>
            {
                options.AddPolicy(txt,
                builder =>
                {
                    builder.AllowAnyOrigin();
                    builder.AllowAnyMethod();
                    builder.AllowAnyHeader();
                });
            });

            /////////////////////////////////////
            builder.Services.AddScoped<IEmployeeManger , EmployeeManger>();
            builder.Services.AddScoped<IEmployeeRepo ,  EmployeeRepo>();

        
            //////////////////////////////////////
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.UseCors(txt);

            app.MapControllers();

            app.Run();
        }
    }
}