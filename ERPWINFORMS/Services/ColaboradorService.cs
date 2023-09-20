using ERPAPI.Model;
using ERPMSB.Model;
using ERPWINFORMS.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ERPWINFORMS.Services
{
    public static class ColaboradorService
    {
        static NameValueCollection appSettings = ConfigurationManager.AppSettings;
        private static HttpClient httpClient { get; set; } = new HttpClient() { BaseAddress = new Uri(appSettings["Ip"]) };

        public async static Task<List<ColaboradorDTO>> getColaboradoresFromRole(string roleId)
        {
            return JsonConvert.DeserializeObject<List<ColaboradorDTO>>(await httpClient.GetAsync($"api/User/getAllUsersFromRole/{roleId}").Result.Content.ReadAsStringAsync());
        }

        public async static Task<List<ColaboradorDTO>> getTodosColaboradores()
        {
            return JsonConvert.DeserializeObject<List<ColaboradorDTO>>(await httpClient.GetAsync("api/User/getAllUsers").Result.Content.ReadAsStringAsync());
        }

        public async static Task<AuthenticationResponse> addDepartmento(string colaboradorId, string departamentoId)
        {
            var model = new RegisterModelUserToRole()
            {
                ColaboradorId = colaboradorId,
                DepartamentoId = departamentoId
            };
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            return JsonConvert.DeserializeObject<AuthenticationResponse>(await httpClient.PostAsync("api/User/addDepartment", content).Result.Content.ReadAsStringAsync());
        }

        public async static Task<AuthenticationResponse> removeFromDepartmento(string colaboradorId, string departamentoId)
        {
            var model = new RegisterModelUserToRole()
            {
                ColaboradorId = colaboradorId,
                DepartamentoId = departamentoId
            };
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            return JsonConvert.DeserializeObject<AuthenticationResponse>(await httpClient.PostAsync("api/Role/removeFromRole", content).Result.Content.ReadAsStringAsync());
        }
    }
}
