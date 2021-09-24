using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace Equipe2_PneuStore.Services
{
    public interface IAuthService
    {
        public IdentityUser GetUser(IdentityUser identityUser);
        public Task<SignInResult> ValidateUser(IdentityUser identityUser);
        public Task<IdentityResult> Create(IdentityUser identityUser);
        public string GenerateToken(IdentityUser identityUser);
    }
}
