namespace ERPGarcia.View
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
            cancelar = new Button();
            Title = new Label();
            inputUser = new TextBox();
            inputEmail = new TextBox();
            inputSenha = new TextBox();
            inputConfSenha = new TextBox();
            labelUser = new Label();
            labelEmail = new Label();
            labelSenha = new Label();
            labelConfSenha = new Label();
            SuspendLayout();
            // 
            // cadastrar
            // 
            cadastrar.Location = new Point(524, 367);
            cadastrar.Name = "cadastrar";
            cadastrar.Size = new Size(75, 23);
            cadastrar.TabIndex = 0;
            cadastrar.Text = "Cadastrar";
            cadastrar.UseVisualStyleBackColor = true;
            cadastrar.Click += Cadastrar_Click;
            // 
            // cancelar
            // 
            cancelar.Location = new Point(443, 367);
            cancelar.Name = "cancelar";
            cancelar.Size = new Size(75, 23);
            cancelar.TabIndex = 1;
            cancelar.Text = "Cancelar";
            cancelar.UseVisualStyleBackColor = true;
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
            inputUser.Location = new Point(12, 127);
            inputUser.Name = "inputUser";
            inputUser.Size = new Size(437, 23);
            inputUser.TabIndex = 3;
            // 
            // inputEmail
            // 
            inputEmail.Location = new Point(12, 174);
            inputEmail.Name = "inputEmail";
            inputEmail.Size = new Size(437, 23);
            inputEmail.TabIndex = 4;
            // 
            // inputSenha
            // 
            inputSenha.Location = new Point(12, 220);
            inputSenha.Name = "inputSenha";
            inputSenha.Size = new Size(437, 23);
            inputSenha.TabIndex = 5;
            // 
            // inputConfSenha
            // 
            inputConfSenha.Location = new Point(12, 266);
            inputConfSenha.Name = "inputConfSenha";
            inputConfSenha.Size = new Size(437, 23);
            inputConfSenha.TabIndex = 6;
            // 
            // labelUser
            // 
            labelUser.AutoSize = true;
            labelUser.Location = new Point(12, 109);
            labelUser.Name = "labelUser";
            labelUser.Size = new Size(47, 15);
            labelUser.TabIndex = 7;
            labelUser.Text = "Usuário";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 156);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(41, 15);
            labelEmail.TabIndex = 8;
            labelEmail.Text = "E-mail";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(12, 202);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(39, 15);
            labelSenha.TabIndex = 9;
            labelSenha.Text = "Senha";
            // 
            // labelConfSenha
            // 
            labelConfSenha.AutoSize = true;
            labelConfSenha.Location = new Point(12, 248);
            labelConfSenha.Name = "labelConfSenha";
            labelConfSenha.Size = new Size(96, 15);
            labelConfSenha.TabIndex = 10;
            labelConfSenha.Text = "Confirmar Senha";
            // 
            // RegistroUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 393);
            Controls.Add(labelConfSenha);
            Controls.Add(labelSenha);
            Controls.Add(labelEmail);
            Controls.Add(labelUser);
            Controls.Add(inputConfSenha);
            Controls.Add(inputSenha);
            Controls.Add(inputEmail);
            Controls.Add(inputUser);
            Controls.Add(Title);
            Controls.Add(cancelar);
            Controls.Add(cadastrar);
            Name = "RegistroUsers";
            Text = "RegistroUsers";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadastrar;
        private Button cancelar;
        private Label Title;
        private TextBox inputUser;
        private TextBox inputEmail;
        private TextBox inputSenha;
        private TextBox inputConfSenha;
        private Label labelUser;
        private Label labelEmail;
        private Label labelSenha;
        private Label labelConfSenha;
    }
}