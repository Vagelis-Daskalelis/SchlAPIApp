﻿using SchlAPIApp.Data;

namespace SchlAPIApp.Services
{
    public interface ITeacherService
    {
        Task<List<User>> GetAllUsersTeachersAsync();
        Task<List<User>> GetAllUsersTeachersAsync(int pageNumber, int pageSize);
        Task<int> GetTeacherCountAsync();
        Task<User?> GetTeacherByUsernameAsync(string? username);
    }
}
