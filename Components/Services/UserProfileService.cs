using cuahangbanle.Data;
using cuahangbanle.DBData.Models;
using Microsoft.EntityFrameworkCore;

namespace cuahangbanle.Components.Services
{
    public class UserProfileService : IUserProfileService
    {
        #region Khởi tạo
        private readonly ApplicationDbContext _context;

        public UserProfileService(ApplicationDbContext context)
        {
            _context = context;
        }
        #endregion

        #region Get data
        public async Task<UserProfile?> GetUserProfileById(string userId)
        {
            return await _context.UserProfiles.FirstOrDefaultAsync(u => u.UserId == userId);
        }
        public async Task<List<UserProfile>> GetAllProfile()
        {
            return await _context.UserProfiles.ToListAsync();
        }
        #endregion

        #region CUD functions
        public async Task CreateUserProfile(UserProfile user)
        {
            _context.UserProfiles.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task<UserProfile> UpdateUserProfile(UserProfile UserProfile)
        {
            _context.UserProfiles.Update(UserProfile);
            await _context.SaveChangesAsync();
            return UserProfile;
        }

        public async Task DeleteUserProfile(string UserProfileId)
        {
            var UserProfile = await GetUserProfileById(UserProfileId);
            if (UserProfile != null)
            {
                _context.UserProfiles.Remove(UserProfile);
                await _context.SaveChangesAsync();
            }
        }
        #endregion
    }
}
