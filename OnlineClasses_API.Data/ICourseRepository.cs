using OnlineClasses_API.Core.Entities;
using OnlineClasses_API.Core.Models;

namespace OnlineClasses_API.Data
{
    public interface ICourseRepository
    {
        Task<List<CourseModel>> GetAllCoursesAsync(int? categoryId = null);
        Task<CourseDetailModel> GetCourseDetailAsync(int courseId);
        //Task AddCourseAsync(Course course);
        //Task UpdateCourseAsync(Course course);
        //Task DeleteCourseAsync(int courseId);
        Task<Course> GetCourseByIdAsync(int courseId);
        void RemoveSessionDetail(SessionDetail sessionDetail);
        Task<List<Instructor>> GetAllInstructorsAsync();

        Task<bool> UpdateCourseThumbnail(string courseThumbnailUrl, int courseId);
    }
}
