using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ERPAPI.Model;
using Newtonsoft.Json.Linq;

namespace ERPAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> userManager;
        private readonly IConfiguration configuration;

        public RoleController(RoleManager<IdentityRole> roleManager,
                              UserManager<IdentityUser> userManager,
                              IConfiguration configuration)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
            this.configuration = configuration;
        }

        [HttpGet]
        [Route("getAllRoles")]
        public async Task<IActionResult> GetAllRoles()
        {
            var roles = await roleManager.Roles.ToListAsync();
            return Ok(roles);
        }

        [HttpPost]
        [Route("createRole")]
        public async Task<IActionResult> CreateRole([FromBody] RoleModel model)
        {
            var role = await roleManager.FindByNameAsync(model.Name);
            if (role != null)
                return BadRequest($"A atribuição {model.Name} já existe.");

            var cRole = new IdentityRole()
            {
                Name = model.Name
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
        [Route("addUserToRole")]
        public async Task<IActionResult> AddUserToRole([FromBody] JObject model)
        {
            if (model["User"] == null || model["Role"] == null)
                return BadRequest();


            var role = await roleManager.FindByNameAsync(model["Role"].ToString());
            var user = await userManager.FindByNameAsync(model["User"].ToString());

            if (role != null && user != null)
            {
                var response = await userManager.AddToRoleAsync(user, role.Name);
                if (response.Succeeded)
                    return Ok($"Usuário {user.UserName} adicionado à atribuição {role.Name}");
            }
            return BadRequest($"Atribuição ou Usuário inválidos.");
        }
    }
}
