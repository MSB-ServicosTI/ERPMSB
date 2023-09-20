using ERPAPI.Context;
using ERPAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace ERPAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<Colaborador> userManager;
        private readonly RoleManager<Departamento> roleManager;
        private readonly AppDbContext appDbContext;
        private readonly IConfiguration configuration;

        public UserController(UserManager<Colaborador> userManager,
                              RoleManager<Departamento> roleManager,
                              AppDbContext appDbContext,
                              IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.appDbContext = appDbContext;
            this.configuration = configuration;
        }

        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            var user = await userManager.FindByNameAsync(model.Username);

            if (user == null)
            {
                return Unauthorized(new AuthenticationResponse { Status = AuthenticationStatus.UserNotFound, Message = "Usuário não encontrado no banco de dados." });
            }

            if (!await userManager.CheckPasswordAsync(user, model.Password))
            {
                return Unauthorized(new AuthenticationResponse { Status = AuthenticationStatus.InvalidPassword, Message = "Senha Incorreta." });
            }

            var userRoles = await userManager.GetRolesAsync(user);

            var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
                };

            foreach (var userRole in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            var token = GetToken(authClaims);

            return Ok("Sucesso!");
        }

        [HttpGet]
        [Route("getUser/{id}")]
        public async Task<IActionResult> GetUserById(Guid id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());
            if (user != null)
                return Ok(user);

            return BadRequest();
        }

        [HttpGet]
        [Route("getAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var lstColaboradores = userManager.Users;
            var lstColaboradoresDTO = ColaboradorMapper.ProjectToDTO(lstColaboradores);

            return Ok(await lstColaboradoresDTO.ToListAsync());
        }

        [HttpGet]
        [Route("getUserRoles/{id}")]
        public async Task<IActionResult> GetUserRoles(string id)
        {
            var userRoles = await appDbContext.UserRoles.Where(a => a.UserId == id).ToListAsync();
            var roles = new List<Departamento>();

            foreach (var role in userRoles)
            {
                roles.Add(await roleManager.FindByIdAsync(role.RoleId));
            }

            var rolesDTO = DepartamentoMapper.ProjectToDTO(roles);
            return Ok(rolesDTO);
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel model)
        {
            var userExists = await userManager.FindByEmailAsync(model.EmailAddress);
            if (userExists != null)
                return StatusCode(StatusCodes.Status500InternalServerError, new AuthenticationResponse { Status = AuthenticationStatus.AlreadyExists, Message = "Um usuário com esse e-mail já existe." });

            Colaborador user = new()
            {
                Email = model.EmailAddress,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username,
                Nome = model.NomeColaborador,
                DataNascimento = model.DataNascimento,
                TipoContrato = model.TipoContrato
            };

            var result = await userManager.CreateAsync(user, model.Password);
            if (!result.Succeeded)
                return StatusCode(StatusCodes.Status500InternalServerError, new AuthenticationResponse { Status = AuthenticationStatus.InternalServerError, Message = $"Falha na criação da conta, cheque as informações e tente novamente mais informações: \"{result.Errors.FirstOrDefault().Description}\"" });

            return Ok(new AuthenticationResponse { Status = AuthenticationStatus.Success, Message = "Usuário criado com sucesso." });
        }

        [HttpPost]
        [Route("addDepartment")]
        public async Task<IActionResult> AddDepartment([FromBody] RegisterModelUserToRole model)
        {
            var departamento = await roleManager.FindByIdAsync(model.DepartamentoId);

            if (departamento == null)
                return BadRequest(new AuthenticationResponse { Status = AuthenticationStatus.DepartmentNotFound, Message = "Não foi possível encontrar o departamento especificado." });

            var user = await userManager.FindByIdAsync(model.ColaboradorId);

            if (user == null)
                return BadRequest(new AuthenticationResponse { Status = AuthenticationStatus.UserNotFound, Message = "Usuário não encontrado." });

            var userRoles = await userManager.GetRolesAsync(user);

            if (userRoles.Any(a => a == departamento.Name))
                return BadRequest(new AuthenticationResponse { Status = AuthenticationStatus.AlreadyExists, Message = $"O usuário já está no departamento {departamento.Name}" });

            var result = await userManager.AddToRoleAsync(user, departamento.Name);

            if (!result.Succeeded)
                return BadRequest(new AuthenticationResponse { Status = AuthenticationStatus.InternalServerError, Message = $"{result.Errors.FirstOrDefault()}" });

            return (Ok(new AuthenticationResponse { Status = AuthenticationStatus.Success, Message = $"Colaborador `{user.Nome}` adicionado ao departamento `{departamento.Name}`" }));
        }

        private JwtSecurityToken GetToken(List<Claim> authClaims)
        {
            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: configuration["JWT:ValidIssuer"],
                audience: configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );

            return token;
        }
    }
}
