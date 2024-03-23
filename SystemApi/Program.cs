
using Microsoft.EntityFrameworkCore;
using System;
using SystemApi.SystemDAL.Context;
using SystemApi.SystemDAL.Repos.PostRepo;
using SystemApi.SystemDAL.Repos.UserRepo;

namespace SystemApi
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
            #region DataBase
            var connectionString = builder.Configuration.GetConnectionString("Systemsocial");
            builder.Services.AddDbContext<SytemDbContext>(options =>
                options.UseSqlServer(connectionString));
            #endregion
            #region Repos
            builder.Services.AddScoped<IPostRepo, PostRepo>();
            builder.Services.AddScoped<IUserRepo, UserRepo>();
            #endregion
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