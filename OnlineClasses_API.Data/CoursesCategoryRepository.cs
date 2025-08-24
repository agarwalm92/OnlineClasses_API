using Microsoft.EntityFrameworkCore;
using OnlineClasses_API.Core.Entities; 
using OnlineClasses_API.Data.Entities; 

namespace OnlineClasses_API.Data
{
    public class CoursesCategoryRepository : ICoursesCategoryRepository
    {
        private readonly OnlineCourseDbContext onlineCourseDbContext;
        public CoursesCategoryRepository(OnlineCourseDbContext onlineCourseDbContext)
        {
            this.onlineCourseDbContext = onlineCourseDbContext;
        }
        public async Task<CourseCategory?> GetCourseCategoryById_Async(int id)
        {
            var data = await onlineCourseDbContext.CourseCategories.FindAsync(id).AsTask();
            return data;
        }

        public async Task<List<CourseCategory>> GetCourseCategory_Async()
        {
            var data = await onlineCourseDbContext.CourseCategories.ToListAsync(); 
            return data;
        }
    }
}
