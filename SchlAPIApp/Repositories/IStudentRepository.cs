using SchlAPIApp.Data;

namespace SchlAPIApp.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Course>> GetStudentCoursesAsync(int id);
        Task<Student?> GetByPhoneNumber(string? phoneNumber);
        Task<List<User>> GetAllUsersStudentsAsync();
    }
}
