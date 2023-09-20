namespace ERPWINFORMS.View
{
    partial class Atribuicoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TreeNode treeNode3 = new TreeNode("Colaboradores");
            TreeNode treeNode4 = new TreeNode("Departamentos");
            tvColaboradores = new TreeView();
            tvDepartamentos = new TreeView();
            cmsDepartamento = new ContextMenuStrip(components);
            tsmiGerenciarDepartamento = new ToolStripMenuItem();
            cmsDepartamento.SuspendLayout();
            SuspendLayout();
            // 
            // tvColaboradores
            // 
            tvColaboradores.Location = new Point(273, 12);
            tvColaboradores.Name = "tvColaboradores";
            treeNode3.Name = "Colaboradores";
            treeNode3.Text = "Colaboradores";
            tvColaboradores.Nodes.AddRange(new TreeNode[] { treeNode3 });
            tvColaboradores.Size = new Size(283, 426);
            tvColaboradores.TabIndex = 7;
            tvColaboradores.BeforeSelect += tvColaboradores_BeforeSelect;
            tvColaboradores.AfterSelect += tvColaboradores_AfterSelect;
            // 
            // tvDepartamentos
            // 
            tvDepartamentos.Location = new Point(562, 12);
            tvDepartamentos.Name = "tvDepartamentos";
            treeNode4.Name = "Departamentos";
            treeNode4.Text = "Departamentos";
            tvDepartamentos.Nodes.AddRange(new TreeNode[] { treeNode4 });
            tvDepartamentos.Size = new Size(226, 426);
            tvDepartamentos.TabIndex = 8;
            tvDepartamentos.AfterSelect += tvDepartamentos_AfterSelect;
            tvDepartamentos.NodeMouseClick += tvDepartamentos_NodeMouseClick;
            tvDepartamentos.MouseClick += tvDepartamentos_MouseClick;
            // 
            // cmsDepartamento
            // 
            cmsDepartamento.Items.AddRange(new ToolStripItem[] { tsmiGerenciarDepartamento });
            cmsDepartamento.Name = "cmsDepartamento";
            cmsDepartamento.Size = new Size(204, 48);
            // 
            // tsmiGerenciarDepartamento
            // 
            tsmiGerenciarDepartamento.Name = "tsmiGerenciarDepartamento";
            tsmiGerenciarDepartamento.Size = new Size(203, 22);
            tsmiGerenciarDepartamento.Text = "Gerenciar Departamento";
            tsmiGerenciarDepartamento.Click += adicionarColaboraodrToolStripMenuItem_Click;
            // 
            // Atribuicoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tvDepartamentos);
            Controls.Add(tvColaboradores);
            Name = "Atribuicoes";
            Text = "Atribuicoes";
            Load += Atribuicoes_Load;
            cmsDepartamento.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TreeView tvColaboradores;
        private TreeView tvDepartamentos;
        private ContextMenuStrip cmsDepartamento;
        private ToolStripMenuItem tsmiGerenciarDepartamento;
    }
}