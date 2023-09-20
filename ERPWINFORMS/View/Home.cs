using ERPGarcia.View;
using ERPMSB.Model;
using ERPWINFORMS.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPMSB.View
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            tsmiAdministracao = new ToolStripMenuItem();
            tsmiRegistrarNovoUsuario = new ToolStripMenuItem();
            tsmiColaboradoresDepartamentos = new ToolStripMenuItem();
            tsmiColaboradoresDepartamentos = new ToolStripMenuItem();
            tsmiSobre = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiAdministracao, tsmiSobre });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(552, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiAdministracao
            // 
            tsmiAdministracao.DropDownItems.AddRange(new ToolStripItem[] { tsmiRegistrarNovoUsuario, tsmiColaboradoresDepartamentos });
            tsmiAdministracao.Name = "tsmiAdministracao";
            tsmiAdministracao.Size = new Size(96, 20);
            tsmiAdministracao.Text = "Administração";
            // 
            // tsmiRegistrarNovoUsuario
            // 
            tsmiRegistrarNovoUsuario.Name = "tsmiRegistrarNovoUsuario";
            tsmiRegistrarNovoUsuario.Size = new Size(243, 22);
            tsmiRegistrarNovoUsuario.Text = "Registrar novo Usuário";
            tsmiRegistrarNovoUsuario.Click += registrarNovoUsuárioToolStripMenuItem_Click;
            // 
            // tsmiColaboradoresDepartamentos
            // 
            tsmiColaboradoresDepartamentos.Name = "tsmiColaboradoresDepartamentos";
            tsmiColaboradoresDepartamentos.Size = new Size(243, 22);
            tsmiColaboradoresDepartamentos.Text = "Colaboradores / Departamentos";
            tsmiColaboradoresDepartamentos.Click += tsmiColaboradoresDepartamentos_Click;
            // 
            // tsmiSobre
            // 
            tsmiSobre.Name = "tsmiSobre";
            tsmiSobre.Size = new Size(49, 20);
            tsmiSobre.Text = "Sobre";
            tsmiSobre.Click += tsmiSobre_Click;
            // 
            // Home
            // 
            ClientSize = new Size(552, 261);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Load += Home_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void registrarNovoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var resgistrarUsuarios = new RegistroUsers();
            resgistrarUsuarios.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void tsmiColaboradoresDepartamentos_Click(object sender, EventArgs e)
        {
            var atribuicoes = new Atribuicoes();
            atribuicoes.Show();
        }

        private void tsmiSobre_Click(object sender, EventArgs e)
        {
            var form = new Sobre();
            form.Show();
        }
    }
}
