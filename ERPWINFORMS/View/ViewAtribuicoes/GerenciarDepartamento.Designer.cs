namespace ERPWINFORMS.View
{
    partial class GerenciarDepartamento
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
            TreeNode treeNode3 = new TreeNode("Colaboradores");
            tvColaboradores = new TreeView();
            txtbNome = new TextBox();
            txtbDataNascimento = new TextBox();
            txtbTipoContrato = new TextBox();
            lblNome = new Label();
            lblDataNascimento = new Label();
            lblTipoContrato = new Label();
            lblDepartamentos = new Label();
            txtbDepartamentos = new TextBox();
            btnAdicionar = new Button();
            btnRemover = new Button();
            SuspendLayout();
            // 
            // tvColaboradores
            // 
            tvColaboradores.Location = new Point(22, 12);
            tvColaboradores.Name = "tvColaboradores";
            treeNode3.Name = "Colaboradores";
            treeNode3.Text = "Colaboradores";
            tvColaboradores.Nodes.AddRange(new TreeNode[] { treeNode3 });
            tvColaboradores.Size = new Size(387, 426);
            tvColaboradores.TabIndex = 0;
            tvColaboradores.NodeMouseClick += tvColaboradores_NodeMouseClick;
            // 
            // txtbNome
            // 
            txtbNome.Enabled = false;
            txtbNome.Location = new Point(455, 30);
            txtbNome.Name = "txtbNome";
            txtbNome.Size = new Size(333, 23);
            txtbNome.TabIndex = 1;
            // 
            // txtbDataNascimento
            // 
            txtbDataNascimento.Enabled = false;
            txtbDataNascimento.Location = new Point(455, 74);
            txtbDataNascimento.Name = "txtbDataNascimento";
            txtbDataNascimento.Size = new Size(333, 23);
            txtbDataNascimento.TabIndex = 2;
            // 
            // txtbTipoContrato
            // 
            txtbTipoContrato.Enabled = false;
            txtbTipoContrato.Location = new Point(455, 118);
            txtbTipoContrato.Name = "txtbTipoContrato";
            txtbTipoContrato.Size = new Size(333, 23);
            txtbTipoContrato.TabIndex = 3;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(455, 12);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(455, 56);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(114, 15);
            lblDataNascimento.TabIndex = 6;
            lblDataNascimento.Text = "Data de Nascimento";
            // 
            // lblTipoContrato
            // 
            lblTipoContrato.AutoSize = true;
            lblTipoContrato.Location = new Point(455, 100);
            lblTipoContrato.Name = "lblTipoContrato";
            lblTipoContrato.Size = new Size(96, 15);
            lblTipoContrato.TabIndex = 7;
            lblTipoContrato.Text = "Tipo de Contrato";
            // 
            // lblDepartamentos
            // 
            lblDepartamentos.AutoSize = true;
            lblDepartamentos.Location = new Point(455, 144);
            lblDepartamentos.Name = "lblDepartamentos";
            lblDepartamentos.Size = new Size(91, 15);
            lblDepartamentos.TabIndex = 8;
            lblDepartamentos.Text = "Departamentos:";
            // 
            // txtbDepartamentos
            // 
            txtbDepartamentos.Enabled = false;
            txtbDepartamentos.Location = new Point(455, 162);
            txtbDepartamentos.Name = "txtbDepartamentos";
            txtbDepartamentos.Size = new Size(333, 23);
            txtbDepartamentos.TabIndex = 4;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Enabled = false;
            btnAdicionar.Location = new Point(455, 415);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 9;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnRemover
            // 
            btnRemover.Enabled = false;
            btnRemover.Location = new Point(536, 415);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(75, 23);
            btnRemover.TabIndex = 10;
            btnRemover.Text = "Remover";
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // GerenciarDepartamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemover);
            Controls.Add(btnAdicionar);
            Controls.Add(lblDepartamentos);
            Controls.Add(lblTipoContrato);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblNome);
            Controls.Add(txtbDepartamentos);
            Controls.Add(txtbTipoContrato);
            Controls.Add(txtbDataNascimento);
            Controls.Add(txtbNome);
            Controls.Add(tvColaboradores);
            Name = "GerenciarDepartamento";
            Text = "Gerenciar Departamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView tvColaboradores;
        private TextBox txtbNome;
        private TextBox txtbDataNascimento;
        private TextBox txtbTipoContrato;
        private Label lblNome;
        private Label lblDataNascimento;
        private Label lblTipoContrato;
        private Label lblDepartamentos;
        private TextBox txtbDepartamentos;
        private Button btnAdicionar;
        private Button btnRemover;
    }
}