﻿using SchlAPIApp.Data;

namespace SchlAPIApp.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<User>> GetAllStudentsAsync();
        Task<List<Course>> GetStudentCoursesAsync(int id);
        Task<Student?> GetStudentAsync(int id);     
        Task<bool> DeleteStudentAsync(int id);
        Task<int> GetStudentCountAsync();
    }
}
