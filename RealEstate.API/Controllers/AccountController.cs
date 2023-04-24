using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using RealEstate.API.DTO;
using RealEstate.API.Models;
using RealEstate.API.Repository;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace RealEstate.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public IConfiguration _appConfig { get; }
        public IMapper _mapper { get; }
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        IAccountRepository _repo;
        public AccountController(IAccountRepository accRepo, IMapper mapper, IConfiguration appConfig, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _repo = accRepo;
            _mapper = mapper;
            _appConfig = appConfig;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        [HttpPost("signup")]

        public async Task<IActionResult> Register(RegisterUserDto registerUserDto)
        {
            var user = _mapper.Map<ApplicationUser>(registerUserDto);

            var val = await _repo.SignUpUserAsync(user, registerUserDto.Password);
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var loginResult = await _signInManager.PasswordSignInAsync(loginUserDTO.Email,
                                                                        loginUserDTO.Password,
                                                                        loginUserDTO.RememberMe,
                                                                        false);
            if (!loginResult.Succeeded)
            {
                ModelState.AddModelError(String.Empty, "Invalid login credentials.");
                return BadRequest(ModelState);
            }

            var user = await this._userManager.FindByEmailAsync(loginUserDTO.Email);

            if (user == null)
            {
                return BadRequest("Something went wrong, please try again later");
            }

            var roles = await this._userManager.GetRolesAsync(user);

            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, loginUserDTO.Email),
                new Claim(ClaimTypes.Role, roles[0])
            };

            var issuer = this._appConfig.GetValue<string>("JWT:Issuer");
            var audience = this._appConfig.GetValue<string>("JWT:Audience");
            var key = this._appConfig.GetValue<string>("JWT:Key");
            var expiry = this._appConfig.GetValue<int>("JWT:ExpiryInMinutes");

            var keyBytes = Encoding.UTF8.GetBytes(key);
            var theKey = new SymmetricSecurityKey(keyBytes);
            var creds = new SigningCredentials(theKey, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(issuer, audience, claims, expires: DateTime.Now.AddMinutes(expiry), signingCredentials: creds);
            return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });
        }
    }
}
   
