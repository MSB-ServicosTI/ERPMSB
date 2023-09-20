using ERPWINFORMS.Model;
using static ERPWINFORMS.Services.ColaboradorService;
using static ERPWINFORMS.Services.DepartamentoService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPWINFORMS.View
{
    public partial class GerenciarDepartamento : Form
    {
        NameValueCollection appSettings = ConfigurationManager.AppSettings;
        private DepartamentoDTO departamento;
        List<ColaboradorDTO> lstColaboradores = new();
        ColaboradorDTO colaboradorSelecionado = new();
        private HttpClient httpClient;

        public GerenciarDepartamento()
        {
            InitializeComponent();
        }

        public GerenciarDepartamento(object departamento)
        {
            InitializeComponent();
            this.departamento = (DepartamentoDTO)departamento;
            this.Text = "Gerenciar Departamento: " + this.departamento.Name;
            tvColaboradores.Nodes[0].Text = tvColaboradores.Nodes[0].Text + " - " + this.departamento.Name;

            httpClient = new HttpClient()
            {
                BaseAddress = new Uri(appSettings["Ip"])
            };

            this.Load += AdicionarColaborador_Load;
        }

        private async void AdicionarColaborador_Load(object? sender, EventArgs e)
        {
            lstColaboradores = await getTodosColaboradores();
            AddColaboradoresAsync();
        }

        private async void AddColaboradoresAsync()
        {
            tvColaboradores.Nodes[0].Nodes.Clear();

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

        private async void btnAdicionar_Click(object sender, EventArgs e)
        {
            var result = await addDepartmento(colaboradorSelecionado.Id, departamento.Id);
            if (!(result.Status == ERPAPI.Model.AuthenticationStatus.Success))
            {
                MessageBox.Show(result.Message);
                return;
            }
            MessageBox.Show($"{colaboradorSelecionado.Nome} adicionado à {departamento.Name} com sucesso.");
            await AtualizarInformacoesColaborador();
        }

        private async void btnRemover_Click(object sender, EventArgs e)
        {
            var result = await removeFromDepartmento(colaboradorSelecionado.Id, departamento.Id);
            if (!(result.Status == ERPAPI.Model.AuthenticationStatus.Success))
            {
                MessageBox.Show(result.Message);
                return;
            }
            MessageBox.Show($"{colaboradorSelecionado.Nome} removido de {departamento.Name} com sucesso.");
            await AtualizarInformacoesColaborador();
        }

        private async void tvColaboradores_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            tvColaboradores.SelectedNode = e.Node;

            if (e.Node.Tag == null)
            {
                colaboradorSelecionado = null;
                txtbNome.Text = txtbDataNascimento.Text = txtbTipoContrato.Text = txtbDepartamentos.Text = string.Empty;
            }

            colaboradorSelecionado = (ColaboradorDTO)e.Node.Tag;
            await AtualizarInformacoesColaborador();
        }

        private async Task AtualizarInformacoesColaborador()
        {
            if (colaboradorSelecionado == null)
            {
                txtbNome.Text = txtbDataNascimento.Text = txtbTipoContrato.Text = txtbDepartamentos.Text = string.Empty;
                btnAdicionar.Enabled = btnRemover.Enabled = false;
                return;
            }
            var departamentosColaborador = await getDepartamentosFromColaborador(colaboradorSelecionado.Id);
            if (departamentosColaborador != null)
                txtbDepartamentos.Text = string.Join(", ", departamentosColaborador.Select(a => a.Name).ToList());


            txtbNome.Text = colaboradorSelecionado.Nome;
            txtbDataNascimento.Text = colaboradorSelecionado.DataNascimento.ToString("dd/MM/yyyy");
            txtbTipoContrato.Text = colaboradorSelecionado.TipoContrato.ToString();
            btnAdicionar.Enabled = btnRemover.Enabled = true;
        }
    }
}
