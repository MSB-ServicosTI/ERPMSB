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
            cadastrar = new Button();
            CancelBotton = new Button();
            Title = new Label();
            inputUser = new TextBox();
            inputEmail = new TextBox();
            inputSenha = new TextBox();
            inputConfSenha = new TextBox();
            labelUser = new Label();
            labelEmail = new Label();
            labelSenha = new Label();
            labelConfSenha = new Label();
            inputNomeColaborador = new TextBox();
            LblNomeColaborador = new Label();
            LblDataNascimento = new Label();
            LblTipoContrato = new Label();
            cbTipoContrato = new ComboBox();
            dtpDataNascimento = new DateTimePicker();
            SuspendLayout();
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(12, 357);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(75, 23);
            cadastrar.TabIndex = 9;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            // 
            // CancelBotton
            // 
            CancelBotton.Location = new Point(250, 357);
            CancelBotton.Name = "CancelBotton";
            CancelBotton.Size = new Size(75, 23);
            CancelBotton.TabIndex = 10;
            CancelBotton.Text = "Cancelar";
            CancelBotton.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(0, 9);
            Title.Name = "Title";
            Title.Size = new Size(260, 37);
            Title.TabIndex = 2;
            Title.Text = "Registro de Usuários";
            // 
            // inputUser
            // 
            inputUser.Location = new Point(11, 108);
            inputUser.Name = "inputUser";
            inputUser.Size = new Size(313, 23);
            inputUser.TabIndex = 2;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(12, 152);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(313, 23);
            inputEmail.TabIndex = 3;
            // 
            // inputSenha
            // 
            inputSenha.Location = new Point(11, 240);
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(313, 23);
            inputSenha.TabIndex = 5;
            // 
            // inputConfSenha
            // 
            inputConfSenha.Location = new Point(12, 284);
            inputConfSenha.Name = "inputConfSenha";
            inputConfSenha.Size = new Size(313, 23);
            inputConfSenha.TabIndex = 6;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(11, 90);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(47, 15);
            labelUser.TabIndex = 7;
            labelUser.Text = "Usuário";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(11, 134);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "E-mail";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(12, 222);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 9;
            labelSenha.Text = "Senha";
            // 
            // labelConfSenha
            // 
            labelConfSenha.AutoSize = true;
            labelConfSenha.Location = new Point(11, 266);
            labelConfSenha.Name = "labelConfSenha";
            labelConfSenha.Size = new Size(96, 15);
            labelConfSenha.TabIndex = 10;
            labelConfSenha.Text = "Confirmar Senha";
            // 
            // inputNomeColaborador
            // 
            inputNomeColaborador.Location = new Point(12, 64);
            inputNomeColaborador.Name = "inputNomeColaborador";
            inputNomeColaborador.Size = new Size(313, 23);
            inputNomeColaborador.TabIndex = 1;
            // 
            // LblNomeColaborador
            // 
            LblNomeColaborador.AutoSize = true;
            LblNomeColaborador.Location = new Point(11, 46);
            LblNomeColaborador.Name = "LblNomeColaborador";
            LblNomeColaborador.Size = new Size(129, 15);
            LblNomeColaborador.TabIndex = 12;
            LblNomeColaborador.Text = "Nome do Colaborador ";
            // 
            // LblDataNascimento
            // 
            LblDataNascimento.AutoSize = true;
            LblDataNascimento.Location = new Point(11, 178);
            LblDataNascimento.Name = "LblDataNascimento";
            LblDataNascimento.Size = new Size(120, 15);
            LblDataNascimento.TabIndex = 14;
            LblDataNascimento.Text = "Data de Nascimento  ";
            // 
            // LblTipoContrato
            // 
            LblTipoContrato.AutoSize = true;
            LblTipoContrato.Location = new Point(12, 310);
            LblTipoContrato.Name = "LblTipoContrato";
            LblTipoContrato.Size = new Size(96, 15);
            LblTipoContrato.TabIndex = 17;
            LblTipoContrato.Text = "Tipo de Contrato";
            // 
            // cbTipoContrato
            // 
            cbTipoContrato.FormattingEnabled = true;
            cbTipoContrato.Items.AddRange(new object[] { "PJ", "CLT", "COOPERATIVO" });
            cbTipoContrato.Location = new Point(11, 328);
            cbTipoContrato.Name = "cbTipoContrato";
            cbTipoContrato.Size = new Size(314, 23);
            cbTipoContrato.TabIndex = 7;
            // 
            // dtpDataNascimento
            // 
            dtpDataNascimento.Format = DateTimePickerFormat.Short;
            dtpDataNascimento.Location = new Point(12, 196);
            dtpDataNascimento.Name = "dtpDataNascimento";
            dtpDataNascimento.Size = new Size(313, 23);
            dtpDataNascimento.TabIndex = 4;
            // 
            // RegistroUsers
            // 
            AcceptButton = cadastrar;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 392);
            Controls.Add(dtpDataNascimento);
            Controls.Add(cbTipoContrato);
            Controls.Add(LblTipoContrato);
            Controls.Add(LblDataNascimento);
            Controls.Add(LblNomeColaborador);
            Controls.Add(inputNomeColaborador);
            Controls.Add(labelConfSenha);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            Controls.Add(labelUser);
            Controls.Add(inputConfSenha);
            Controls.Add(inputSenha);
            Controls.Add(inputEmail);
            Controls.Add(inputUser);
            Controls.Add(Title);
            Controls.Add(CancelBotton);
            Controls.Add(cadastrar);
            Name = "RegistroUsers";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadastrar;
        private Button CancelBotton;
        private Label Title;
        private TextBox inputUser;
        private TextBox inputEmail;
        private TextBox inputSenha;
        private TextBox inputConfSenha;
        private Label labelUser;
        private Label labelEmail;
        private Label labelSenha;
        private Label labelConfSenha;
        private TextBox inputNomeColaborador;
        private Label LblNomeColaborador;
        private Label LblDataNascimento;
        private Label LblTipoContrato;
        private ComboBox cbTipoContrato;
        private DateTimePicker dtpDataNascimento;
    }
}