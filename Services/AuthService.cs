using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;


namespace Equipe2_PneuStore.Services
{
    public class AuthService :IAuthService
    {
        UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> _signInManager;
        IConfiguration _config;

        public AuthService(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager, IConfiguration config)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _config = config;
        }

        public IdentityUser GetUser(IdentityUser identityUser)
        {
            var user = _userManager.FindByNameAsync(identityUser.UserName).Result;
            var valid = _signInManager.CheckPasswordSignInAsync(user, identityUser.PasswordHash, false);
            return valid.Result.Succeeded ? user : null;
        }

        public async Task<IdentityResult> Create(IdentityUser identityUser)
        {
            var result = await _userManager.CreateAsync(identityUser, identityUser.PasswordHash);
            if (result.Succeeded)
            {
                var user = _userManager.FindByNameAsync(identityUser.UserName);
                //await _userManager.AddToRoleAsync(user.Result, Enum.GetName(default(RoleType)));
            }
            return result;
        }

        public async Task<SignInResult> ValidateUser(IdentityUser identityUser)
        {
            var user = await _userManager.FindByNameAsync(identityUser.UserName);
            var valid = await _signInManager.CheckPasswordSignInAsync(user, identityUser.PasswordHash, false);
            return valid;
        }

        public string GenerateToken(IdentityUser identityUser)
        {
            var user = GetUser(identityUser);
            //var role = GetUserRole(user);
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_config["Jwt:Key"]);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Name, user.UserName.ToString()),
                    //new Claim(ClaimTypes.Role, role),
                    new Claim(ClaimTypes.NameIdentifier, user.Id)
                }),
                Expires = DateTime.UtcNow.AddHours(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
