namespace ERPGarcia
{
    partial class TelaInicial
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            TxtBLogin = new TextBox();
            TxtBSenha = new TextBox();
            ButtonLogin = new Button();
            SuspendLayout();
            // 
            // TxtBLogin
            // 
            TxtBLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBLogin.Location = new Point(52, 107);
            TxtBLogin.Name = "TxtBLogin";
            TxtBLogin.PlaceholderText = "Insira seu Login aqui";
            TxtBLogin.Size = new Size(358, 23);
            TxtBLogin.TabIndex = 0;
            TxtBLogin.TabStop = false;
            // 
            // TxtBSenha
            // 
            TxtBSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBSenha.Location = new Point(52, 163);
            TxtBSenha.Name = "TxtBSenha";
            TxtBSenha.PasswordChar = '*';
            TxtBSenha.PlaceholderText = "Insira sua Senha aqui";
            TxtBSenha.Size = new Size(358, 23);
            TxtBSenha.TabIndex = 1;
            TxtBSenha.TabStop = false;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonLogin.Location = new Point(190, 229);
            ButtonLogin.MaximumSize = new Size(0, 23);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(75, 23);
            ButtonLogin.TabIndex = 2;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // TelaInicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 366);
            Controls.Add(ButtonLogin);
            Controls.Add(TxtBSenha);
            Controls.Add(TxtBLogin);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(484, 405);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBLogin;
        private TextBox TxtBSenha;
        private Button ButtonLogin;

    }
}