using OnlineClasses_API.Core.Entities;
using OnlineClasses_API.Core.Models;
using OnlineClasses_API.Data;

namespace OnlineClasses_API.Services
{
    public interface ICourseCategoryService
    {
        Task<CourseCategoryModel?> GetCourseCategoryById_Async(int id);
        Task<List<CourseCategoryModel>> GetCourseCategory_Async();
    }
    public class CourseCategoryService : ICourseCategoryService
    {
        private readonly ICoursesCategoryRepository coursesCategory;

        public CourseCategoryService(ICoursesCategoryRepository coursesCategory)
        {
            this.coursesCategory = coursesCategory;
        }
        public async Task<CourseCategoryModel?> GetCourseCategoryById_Async(int id)
        {
            CourseCategory data = await coursesCategory.GetCourseCategoryById_Async(id);
            return data == null ? null : new CourseCategoryModel
            {
                CategoryId = data.CategoryId,
                Description = data.Description,
                CategoryName = data.CategoryName
            };
        }

        public async Task<List<CourseCategoryModel>> GetCourseCategory_Async()
        {
            var data = await coursesCategory.GetCourseCategory_Async();
            var modelData = data.Select(x => new CourseCategoryModel
            {
                CategoryId = x.CategoryId,
                CategoryName = x.CategoryName,
                Description = x.Description
            }).ToList();
            return modelData;
        }
    }
}
