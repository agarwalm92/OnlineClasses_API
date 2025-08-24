
using Microsoft.EntityFrameworkCore;
using OnlineClasses_API.Data;
using OnlineClasses_API.Data.Entities;
using OnlineClasses_API.Services;

namespace OnlineClasses_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            #region ServicesDI
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            builder.Services.AddDbContext<OnlineCourseDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("DbContext"),
                    provideroptions => provideroptions.EnableRetryOnFailure());
            });

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<ICoursesCategoryRepository, CoursesCategoryRepository>();
            builder.Services.AddScoped<ICourseCategoryService, CourseCategoryService>();
            #endregion

            #region Middleware
            var app = builder.Build();
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.MapControllers();
            app.Run();
            #endregion
        }
    }
}
