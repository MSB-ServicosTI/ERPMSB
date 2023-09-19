using ERPGarcia.View;
using ERPMSB.Model;
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
            tsmiAdministracao = new ToolStripMenuItem();
            tsmiRegistrarNovoUsuário = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            tsmiInformacoes = new ToolStripMenuItem();
            tsmiSobre = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tsmiAdministracao
            // 
            tsmiAdministracao.DropDownItems.AddRange(new ToolStripItem[] { tsmiRegistrarNovoUsuário });
            tsmiAdministracao.Name = "tsmiAdministracao";
            tsmiAdministracao.Size = new Size(96, 20);
            tsmiAdministracao.Text = "Administração";
            // 
            // tsmiRegistrarNovoUsuário
            // 
            tsmiRegistrarNovoUsuário.Name = "tsmiRegistrarNovoUsuário";
            tsmiRegistrarNovoUsuário.Size = new Size(193, 22);
            tsmiRegistrarNovoUsuário.Text = "Registrar novo Usuário";
            tsmiRegistrarNovoUsuário.Click += registrarNovoUsuárioToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { tsmiAdministracao, tsmiInformacoes, tsmiSobre });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(552, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tsmiInformacoes
            // 
            tsmiInformacoes.Name = "tsmiInformacoes";
            tsmiInformacoes.Size = new Size(88, 20);
            tsmiInformacoes.Text = "Informações ";
            // 
            // tsmiSobre
            // 
            tsmiSobre.Name = "tsmiSobre";
            tsmiSobre.Size = new Size(49, 20);
            tsmiSobre.Text = "Sobre";
            tsmiSobre.Click += sobreToolStripMenuItem_Click;
            // 
            // Home
            // 
            ClientSize = new Size(552, 261);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
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

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sobre = new Sobre();
            sobre.Show();
        }
    }
}
