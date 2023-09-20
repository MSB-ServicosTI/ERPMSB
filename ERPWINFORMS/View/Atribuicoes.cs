using ERPMSB.Model;
using ERPWINFORMS.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Internal;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPWINFORMS.View
{
    public partial class Atribuicoes : CustomForm
    {
        NameValueCollection appSettings = ConfigurationManager.AppSettings;
        HttpClient httpClient;
        List<DepartamentoDTO> lstDepartamentos = new();
        List<ColaboradorDTO> lstColaboradores = new();


        public Atribuicoes()
        {
            InitializeComponent();
            httpClient = new HttpClient()
            {
                BaseAddress = new Uri(appSettings["Ip"])
            };
        }

        private async void Atribuicoes_Load(object sender, EventArgs e)
        {
            lstDepartamentos = JsonConvert.DeserializeObject<List<DepartamentoDTO>>(await httpClient.GetAsync("api/Role/getAllRoles").Result.Content.ReadAsStringAsync());
            lstColaboradores = JsonConvert.DeserializeObject<List<ColaboradorDTO>>(await httpClient.GetAsync("api/User/getAllUsers").Result.Content.ReadAsStringAsync());

            AddDepartamentosAsync();
            AddColaboradoresAsync();
        }

        private async void AddDepartamentosAsync()
        {
            await Parallel.ForEachAsync(lstDepartamentos, async (item, token) =>
            {
                TreeNode node = new TreeNode(item.Name);
                node.Tag = item;
                this.Invoke(() =>
                {
                    tvDepartamentos.Nodes[0].Nodes.Add(node);
                });
            });

            tvDepartamentos.ExpandAll();
        }

        private async void AddColaboradoresAsync()
        {
            await Parallel.ForEachAsync(lstColaboradores, async (item, token) =>
            {
                TreeNode node = new TreeNode(item.Nome);
                node.Tag = item;
                this.Invoke(() =>
                {
                    tvColaboradores.Nodes[0].Nodes.Add(node);
                });
            });

            tvColaboradores.ExpandAll();
        }
    }
}
