namespace ERPMSB.View
{
    partial class RegistroUsers
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
            cadastrar = new Button();
            cancelar = new Button();
            Title = new Label();
            inputUser = new TextBox();
            inputEmail = new TextBox();
            inputSenha = new TextBox();
            inputConfSenha = new TextBox();
            lblUser = new Label();
            lblEmail = new Label();
            lblSenha = new Label();
            lblConfSenha = new Label();
            inputNomeColaborador = new TextBox();
            lblNomeColaborador = new Label();
            lblDataNascimento = new Label();
            dtpDataNascimento = new DateTimePicker();
            cbxTipoContrato = new ComboBox();
            lblTipoContrato = new Label();
            registerModelBindingSource = new BindingSource(components);
            colaboradorBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)registerModelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)colaboradorBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(118, 382);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(75, 23);
            cadastrar.TabIndex = 8;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += Cadastrar_Click;
            // 
            // cancelar
            // 
            cancelar.Location = new Point(248, 382);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(75, 23);
            cancelar.TabIndex = 9;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
            cancelar.Click += cancelar_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(20, 9);
            Title.Name = "Title";
            Title.Size = new Size(260, 37);
            Title.TabIndex = 2;
            Title.Text = "Registro de Usuários";
            // 
            // inputUser
            // 
            inputUser.AcceptsTab = true;
            inputUser.Location = new Point(18, 167);
            inputUser.Name = "inputUser";
            inputUser.Size = new Size(433, 23);
            inputUser.TabIndex = 3;
            // 
            // inputEmail
            // 
            inputEmail.AcceptsTab = true;
            inputEmail.Location = new Point(20, 123);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(431, 23);
            inputEmail.TabIndex = 2;
            // 
            // inputSenha
            // 
            inputSenha.AcceptsTab = true;
            inputSenha.Location = new Point(20, 211);
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(433, 23);
            inputSenha.TabIndex = 4;
            // 
            // inputConfSenha
            // 
            inputConfSenha.AcceptsTab = true;
            inputConfSenha.Location = new Point(18, 258);
            inputConfSenha.Name = "inputConfSenha";
            inputConfSenha.Size = new Size(433, 23);
            inputConfSenha.TabIndex = 5;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(20, 149);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(96, 15);
            lblUser.TabIndex = 7;
            lblUser.Text = "Usuário de Login";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 105);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "E-mail";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(20, 193);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 9;
            lblSenha.Text = "Senha";
            // 
            // lblConfSenha
            // 
            lblConfSenha.AutoSize = true;
            lblConfSenha.Location = new Point(18, 238);
            lblConfSenha.Name = "lblConfSenha";
            lblConfSenha.Size = new Size(96, 15);
            lblConfSenha.TabIndex = 10;
            lblConfSenha.Text = "Confirmar Senha";
            // 
            // inputNomeColaborador
            // 
            inputNomeColaborador.AcceptsTab = true;
            inputNomeColaborador.Location = new Point(18, 79);
            inputNomeColaborador.Name = "inputNomeColaborador";
            inputNomeColaborador.Size = new Size(435, 23);
            inputNomeColaborador.TabIndex = 1;
            // 
            // lblNomeColaborador
            // 
            lblNomeColaborador.AutoSize = true;
            lblNomeColaborador.Location = new Point(20, 61);
            lblNomeColaborador.Name = "lblNomeColaborador";
            lblNomeColaborador.Size = new Size(126, 15);
            lblNomeColaborador.TabIndex = 12;
            lblNomeColaborador.Text = "Nome do Colaborador";
            // 
            // lblDataNascimento
            // 
            lblDataNascimento.AutoSize = true;
            lblDataNascimento.Location = new Point(18, 285);
            lblDataNascimento.Name = "lblDataNascimento";
            lblDataNascimento.Size = new Size(113, 21);
            lblDataNascimento.TabIndex = 13;
            lblDataNascimento.Text = "Data de nascimento";
            lblDataNascimento.UseCompatibleTextRendering = true;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.CustomFormat = "";
            dtpDataNascimento.Format = DateTimePickerFormat.Custom;
            dtpDataNascimento.Location = new Point(18, 305);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(433, 23);
            dtpDataNascimento.TabIndex = 6;
            // 
            // cbxTipoContrato
            // 
            cbxTipoContrato.FormattingEnabled = true;
            cbxTipoContrato.Items.AddRange(new object[] { "PJ", "CLT", "COOPERATIVO" });
            cbxTipoContrato.Location = new Point(18, 351);
            cbxTipoContrato.Name = "cbxTipoContrato";
            cbxTipoContrato.Size = new Size(433, 23);
            cbxTipoContrato.TabIndex = 7;
            // 
            // lblTipoContrato
            // 
            lblTipoContrato.AutoSize = true;
            lblTipoContrato.Location = new Point(18, 333);
            lblTipoContrato.Name = "lblTipoContrato";
            lblTipoContrato.Size = new Size(94, 15);
            lblTipoContrato.TabIndex = 17;
            lblTipoContrato.Text = "Tipo de contrato";
            // 
            // registerModelBindingSource
            // 
            registerModelBindingSource.DataSource = typeof(Model.RegisterModel);
            // 
            // colaboradorBindingSource
            // 
            colaboradorBindingSource.DataSource = typeof(ERPWINFORMS.Model.Colaborador);
            // 
            // RegistroUsers
            // 
            AcceptButton = cadastrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancelar;
            ClientSize = new Size(456, 433);
            Controls.Add(lblTipoContrato);
            Controls.Add(cbxTipoContrato);
            Controls.Add(dtpDataNascimento);
            Controls.Add(lblDataNascimento);
            Controls.Add(lblNomeColaborador);
            Controls.Add(inputNomeColaborador);
            Controls.Add(lblConfSenha);
            Controls.Add(lblSenha);
            Controls.Add(lblEmail);
            Controls.Add(lblUser);
            Controls.Add(inputConfSenha);
            Controls.Add(inputSenha);
            Controls.Add(inputEmail);
            Controls.Add(inputUser);
            Controls.Add(Title);
            Controls.Add(cancelar);
            Controls.Add(cadastrar);
            Name = "RegistroUsers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Usuários";
            ((System.ComponentModel.ISupportInitialize)registerModelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)colaboradorBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label Title;
        private Label lblNomeColaborador;
        private TextBox inputNomeColaborador;
        private Label lblEmail;
        private TextBox inputEmail;
        private Label lblUser;
        private TextBox inputUser;
        private Label lblSenha;
        private TextBox inputSenha;
        private Label lblConfSenha;
        private TextBox inputConfSenha;
        private Label lblDataNascimento;
        private DateTimePicker dtpDataNascimento;
        private Label lblTipoContrato;
        private ComboBox cbxTipoContrato;
        private Button cadastrar;
        private Button cancelar;
        private BindingSource registerModelBindingSource;
        private BindingSource colaboradorBindingSource;
    }
}