using backedn_aiepflix.DTOs;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace backedn_aiepflix.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;

        public AccountController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
        }

        [HttpPost]
        public async Task<ActionResult<UserToken>> CreateUser(UserInfo userInfo)
        {
            var user = new IdentityUser { Email = userInfo.Email, UserName = userInfo.Email };
            var resul = await _userManager.CreateAsync(user, userInfo.Password);
            if (resul.Succeeded)
            {
                return BuildToken(userInfo, new List<string>());
            }
            else
            {
                return BadRequest("Email o Password inválidos");
            }
        } 

        private UserToken BuildToken(UserInfo userInfo, IList<string> roles)
        {
            var claims = new List<Claim>()
            {
                new Claim(JwtRegisteredClaimNames.UniqueName, userInfo.Email),
                new Claim(ClaimTypes.Name, userInfo.Email),
                new Claim("mivalor","lo que yo quiera"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            foreach(var rol in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, rol));
            }

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt:key"]));
            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var expiration = DateTime.UtcNow.AddMinutes(1);

            JwtSecurityToken token = new JwtSecurityToken
                (
                    issuer: null,
                    audience: null,
                    claims: claims,
                    expires: expiration,
                    signingCredentials: cred
                );

            return new UserToken()
            {
                Token = new JwtSecurityTokenHandler().WriteToken(token),
                Expiration = expiration
            };
        } 
    }
}
