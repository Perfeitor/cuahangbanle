using cuahangbanle.Data;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;

namespace cuahangbanle.Components.Services
{
    public class UserService : IUserService
    {
        private readonly AuthenticationStateProvider auth;
        public UserService(AuthenticationStateProvider auth)
        {
            this.auth = auth;
        }

        public async Task<ClaimsPrincipal> GetCurrentUserPrincipal()
        {
            var authState = await auth.GetAuthenticationStateAsync();
            return authState.User;
        }

    }
}
