using SchlAPIApp.Data;
using SchlAPIApp.DTO;
using SchlAPIApp.Models;

namespace SchlAPIApp.Services
{
    public interface IUserService
    {
        Task<User?> SignUpUserAsync(UserSignupDTO request);
        Task<User?> VerifyAndGetUserAsync(UserLoginDTO credentials);
        Task<User?> UpdateUserAsync(int userId, UserDTO userDTO);
        Task<User?> UpdateUserPatchAsync(int userId, UserPatchDTO request);
        Task<User?> GetUserByUsernameAsync(string username);
        Task<List<User>> GetAllUsersFiltered(int pageNumber, int pageSize, 
            UserFiltersDTO userFiltersDTO);
        string CreateUserToken(int userId, string? userName, string? email, UserRole? userRole, 
            string? appSecurityKey);
        Task<UserTeacherReadOnlyDTO?> GetUserTeacherByUsername(string? username);
        Task DeleteUserAsync(int id);
    }
}
