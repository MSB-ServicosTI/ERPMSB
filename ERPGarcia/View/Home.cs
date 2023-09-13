using ERPGarcia.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERPGarcia.View
{
    public partial class Home : CustomForm
    {
        public Home()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            administraçãoToolStripMenuItem = new ToolStripMenuItem();
            registrarNovoUsuárioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { administraçãoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(552, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // administraçãoToolStripMenuItem
            // 
            administraçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { registrarNovoUsuárioToolStripMenuItem });
            administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            administraçãoToolStripMenuItem.Size = new Size(96, 20);
            administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // registrarNovoUsuárioToolStripMenuItem
            // 
            registrarNovoUsuárioToolStripMenuItem.Name = "registrarNovoUsuárioToolStripMenuItem";
            registrarNovoUsuárioToolStripMenuItem.Size = new Size(193, 22);
            registrarNovoUsuárioToolStripMenuItem.Text = "Registrar novo Usuário";
            registrarNovoUsuárioToolStripMenuItem.Click += registrarNovoUsuárioToolStripMenuItem_Click;
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
    }
}
