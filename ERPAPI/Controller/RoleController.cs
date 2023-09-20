using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ERPAPI.Model;
using Newtonsoft.Json.Linq;
using ERPAPI.Context;

namespace ERPAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<Departamento> roleManager;
        private readonly UserManager<Colaborador> userManager;
        private readonly AppDbContext appDbContext;

        public RoleController(RoleManager<Departamento> roleManager,
                              UserManager<Colaborador> userManager,
                              AppDbContext appDbContext)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.appDbContext = appDbContext;
        }

        [HttpGet]
        [Route("getAllRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = roleManager.Roles;
            var rolesDTO = DepartamentoMapper.ProjectToDTO(roles);
            return Ok(await rolesDTO.ToListAsync());
        }

        [HttpGet]
        [Route("getAllUsersFromRole/{id}")]
        public async Task<IActionResult> GetAllusersFromRole(string id)
        {
            var roleUsers = await appDbContext.UserRoles.Where(a => a.RoleId == id).ToListAsync();
            var users = new List<Colaborador>();

            foreach (var user in roleUsers)
            {
                users.Add(await userManager.FindByIdAsync(user.UserId));
            }

            var usersDTO = ColaboradorMapper.ProjectToDTO(users);
            return Ok(usersDTO);
        }

        [HttpPost]
        [Route("createRole")]
        public async Task<IActionResult> CreateRole([FromBody] RoleModel model)
        {
            var role = await roleManager.FindByNameAsync(model.Name);
            if (role != null)
                return BadRequest($"A atribuição {model.Name} já existe.");

            var cRole = new Departamento()
            {
                Name = model.Name,
                Nome = model.Name
            };

            var result = await roleManager.CreateAsync(cRole);


            if (result.Succeeded)
                return Ok($"Atribuição {model.Name} criado com sucesso.");

            else
                return BadRequest($"Erro: {result.Errors.FirstOrDefault()?.Description}");
        }

        [HttpDelete]
        [Route("deleteRole")]
        public async Task<IActionResult> DeleteRole([FromBody] RoleModel model)
        {
            var role = await roleManager.FindByNameAsync(model.Name);

            if (role == null)
                return BadRequest($"Atribuição com o nome {model.Name} não existe.");

            var result = await roleManager.DeleteAsync(role);

            if (result.Succeeded)
                return Ok($"Atribuição {role.Name} excluída com sucesso.");

            return BadRequest($"Erro: {result.Errors.FirstOrDefault()?.Description}");
        }

        [HttpPost]
        [Route("removeFromRole")]
        public async Task<IActionResult> RemoveFromRole([FromBody] RegisterModelUserToRole model)
        {
            var role = await roleManager.FindByIdAsync(model.DepartamentoId);
            var user = await userManager.FindByIdAsync(model.ColaboradorId);
            var result = await userManager.RemoveFromRoleAsync(user, role.Name);

            if (result.Succeeded)
                return Ok(new AuthenticationResponse { Status = AuthenticationStatus.Success, Message = $"{user.Nome} removido do departamento {role.Nome}" });

            return BadRequest(new AuthenticationResponse { Status = AuthenticationStatus.InternalServerError, Message = result.Errors.FirstOrDefault().Description });
        }

        [HttpPost]
        [Route("addUser")]
        public async Task<IActionResult> AddUserToRole([FromBody] RegisterModelUserToRole model)
        {
            var role = await roleManager.FindByIdAsync(model.DepartamentoId);
            var user = await userManager.FindByIdAsync(model.ColaboradorId);

            if (role != null && user != null)
            {

                var response = await userManager.AddToRoleAsync(user, role.Name);
                if (response.Succeeded)
                    return Ok($"Usuário {user.UserName} adicionado à atribuição {role.Name}");

                return BadRequest(response.Errors.FirstOrDefault());
            }

            return BadRequest($"Atribuição ou Usuário inválidos.");
        }
    }
}
