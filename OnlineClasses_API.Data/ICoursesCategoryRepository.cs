using OnlineClasses_API.Core.Entities;
using OnlineClasses_API.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineClasses_API.Data
{
    public interface ICoursesCategoryRepository
    {
        Task<CourseCategory?> GetCourseCategoryById_Async(int id);

        Task<List<CourseCategory>> GetCourseCategory_Async();
    }

}
