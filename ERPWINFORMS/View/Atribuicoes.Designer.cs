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
            TreeNode treeNode1 = new TreeNode("Colaboradores");
            TreeNode treeNode2 = new TreeNode("Departamentos");
            tvColaboradores = new TreeView();
            tvDepartamentos = new TreeView();
            SuspendLayout();
            // 
            // tvColaboradores
            // 
            tvColaboradores.Location = new Point(273, 12);
            tvColaboradores.Name = "tvColaboradores";
            treeNode1.Name = "Colaboradores";
            treeNode1.Text = "Colaboradores";
            tvColaboradores.Nodes.AddRange(new TreeNode[] { treeNode1 });
            tvColaboradores.Size = new Size(283, 426);
            tvColaboradores.TabIndex = 7;
            // 
            // tvDepartamentos
            // 
            tvDepartamentos.Location = new Point(562, 12);
            tvDepartamentos.Name = "tvDepartamentos";
            treeNode2.Name = "Departamentos";
            treeNode2.Text = "Departamentos";
            tvDepartamentos.Nodes.AddRange(new TreeNode[] { treeNode2 });
            tvDepartamentos.Size = new Size(226, 426);
            tvDepartamentos.TabIndex = 8;
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
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private TreeView tvColaboradores;
        private TreeView tvDepartamentos;
    }
}