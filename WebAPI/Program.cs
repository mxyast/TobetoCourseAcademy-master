
using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concrete.EntityFramework;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           
            // Add services to the container.
            // Soyut s�n�f� somut s�n�f atamas� yapmak i�in :
            // AddSingleton data tutumuyorsan kullan�caks�n 
            // AddTransient ,AddScoped data l� ise kullan�lacak olan
            builder.Services.AddControllers();
            builder.Services.AddSingleton<ICourseService,CourseManager>();
            builder.Services.AddSingleton<ICourseDal,EfCourseDal>();
            //Autofac, Ninject, CastleWindsor, StructureMap, LightInject, DryInject-->IoC Container
            //Autofac -->AOPsa�l�yor

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

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}