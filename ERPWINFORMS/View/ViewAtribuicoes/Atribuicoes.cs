using ERPCommon;
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
using System.Xml.Linq;

namespace ERPWINFORMS.View
{
    public partial class Atribuicoes : Form
    {
        NameValueCollection appSettings = ConfigurationManager.AppSettings;
        HttpClient httpClient;
        List<DepartamentoDTO> lstDepartamentos = new();
        List<ColaboradorDTO> lstColaboradores = new();
        string departamentos = "Departamentos ";
        string colaboradores = "Colaboradores ";
        bool primeiraChamadaColaboradores = true;
        bool primeiraChamadaDepartamentos = true;


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
            tvDepartamentos.Nodes[0].Nodes.Clear();
            this.Invoke(() =>
            {
                tvDepartamentos.Nodes[0].Text = departamentos;
                tvDepartamentos.Update();
            });

            await Parallel.ForEachAsync(lstDepartamentos, async (item, token) =>
            {
                TreeNode node = new TreeNode(item.Name);
                node.ContextMenuStrip = cmsDepartamento;
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
            tvColaboradores.Nodes[0].Nodes.Clear();
            this.Invoke(() =>
            {
                tvColaboradores.Nodes[0].Text = colaboradores;
                tvColaboradores.Update();
            });

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

        private void tvColaboradores_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private async void tvColaboradores_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                if (!primeiraChamadaColaboradores)
                    AddDepartamentosAsync();
                return;
            }

            var colaborador = (ColaboradorDTO)e.Node.Tag;
            var roles = JsonConvert.DeserializeObject<List<DepartamentoDTO>>(await httpClient.GetAsync($"api/User/getUserRoles/{colaborador.Id}").Result.Content.ReadAsStringAsync());

            tvDepartamentos.Nodes[0].Nodes.Clear();
            this.Invoke(() =>
            {
                tvDepartamentos.Nodes[0].Text = departamentos + "- " + colaborador.Nome;
                tvDepartamentos.Update();
            });

            foreach (var item in roles)
            {
                TreeNode node = new TreeNode(item.Name);
                node.ContextMenuStrip = cmsDepartamento;
                node.Tag = item;
                this.Invoke(() =>
                {
                    tvDepartamentos.Nodes[0].Nodes.Add(node);
                });
            }

            primeiraChamadaColaboradores = false;
        }

        private async void tvDepartamentos_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null)
            {
                if (!primeiraChamadaDepartamentos)
                    AddColaboradoresAsync();
                return;
            }
            var departamento = (DepartamentoDTO)e.Node.Tag;

            var test = await httpClient.GetAsync($"api/Role/getAllUsersFromRole/{departamento.Id}").Result.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<List<ColaboradorDTO>>(await httpClient.GetAsync($"api/Role/getAllUsersFromRole/{departamento.Id}").Result.Content.ReadAsStringAsync());

            tvColaboradores.Nodes[0].Nodes.Clear();
            this.Invoke(() =>
            {
                tvColaboradores.Nodes[0].Text = colaboradores + "- " + departamento.Name;
                tvColaboradores.Update();
            });

            foreach (var item in users)
            {
                TreeNode node = new TreeNode(item.Nome);
                node.Tag = item;
                this.Invoke(() =>
                {
                    tvColaboradores.Nodes[0].Nodes.Add(node);
                });
            }

            primeiraChamadaDepartamentos = false;
        }

        private void tvDepartamentos_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;
        }

        private void tvDepartamentos_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvDepartamentos.SelectedNode = e.Node;
            if (e.Button == MouseButtons.Right && e.Node.Tag != null)
            {
                e.Node.ContextMenuStrip.Show();
            }
        }

        private void adicionarColaboraodrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new GerenciarDepartamento(tvDepartamentos.SelectedNode.Tag);
            form.FormClosed += FormGerenciarDepartamento_FormClosed;
            this.Hide();
            form.Show();
        }

        private void FormGerenciarDepartamento_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
