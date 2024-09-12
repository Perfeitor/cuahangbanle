using System.Security.Claims;

namespace cuahangbanle.Components.Services
{
    public interface IUserService
    {
        Task<ClaimsPrincipal> GetCurrentUserPrincipal();
    }
}
