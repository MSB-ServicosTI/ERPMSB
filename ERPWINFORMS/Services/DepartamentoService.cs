using ERPWINFORMS.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPWINFORMS.Services
{
    public static class DepartamentoService
    {
        static NameValueCollection appSettings = ConfigurationManager.AppSettings;
        private static HttpClient httpClient { get; set; } = new HttpClient() { BaseAddress = new Uri(appSettings["Ip"]) };

        public async static Task<List<DepartamentoDTO>> getDepartamentosFromColaborador(string userId)
        {
            var conferesDoConferes = await httpClient.GetAsync($"api/User/getUserRoles/{userId}").Result.Content.ReadAsStringAsync();
            var conferes = JsonConvert.DeserializeObject<List<DepartamentoDTO>>(await httpClient.GetAsync($"api/User/getUserRoles/{userId}").Result.Content.ReadAsStringAsync());
            return JsonConvert.DeserializeObject<List<DepartamentoDTO>>(await httpClient.GetAsync($"api/User/getUserRoles/{userId}").Result.Content.ReadAsStringAsync());
        }

        public async static Task<List<DepartamentoDTO>> getTodosDepartamentos()
        {
            return JsonConvert.DeserializeObject<List<DepartamentoDTO>>(await httpClient.GetAsync("api/Role/getAllRoles").Result.Content.ReadAsStringAsync());
        }
    }
}
