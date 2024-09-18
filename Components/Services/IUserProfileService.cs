using cuahangbanle.Data;
using cuahangbanle.DBData.Models;

namespace cuahangbanle.Components.Services
{
    public interface IUserProfileService
    {
        Task CreateUserProfile(UserProfile user);
        Task DeleteUserProfile(string UserProfileId);
        Task<List<UserProfile>> GetAllProfile();
        Task<UserProfile?> GetUserProfileById(string userId);
        Task<UserProfile> UpdateUserProfile(UserProfile UserProfile);
    }
}
