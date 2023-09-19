namespace ERPMSB
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
            CheckBoxShowPass = new CheckBox();
            LblLogin = new Label();
            LblSenha = new Label();
            menuStrip1 = new MenuStrip();
            Strip = new ToolStripMenuItem();
            toolStripTextBox1 = new ToolStripTextBox();
            menuStrip1.SuspendLayout();
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
            // 
            // TxtBSenha
            // 
            TxtBSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBSenha.Location = new Point(52, 163);
            TxtBSenha.Name = "TxtBSenha";
            TxtBSenha.PlaceholderText = "Insira sua Senha aqui";
            TxtBSenha.Size = new Size(358, 23);
            TxtBSenha.TabIndex = 1;
            TxtBSenha.UseSystemPasswordChar = true;
            // 
            // ButtonLogin
            // 
            ButtonLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonLogin.Location = new Point(190, 229);
            ButtonLogin.MaximumSize = new Size(0, 23);
            ButtonLogin.Name = "ButtonLogin";
            ButtonLogin.Size = new Size(75, 23);
            ButtonLogin.TabIndex = 0;
            ButtonLogin.Text = "Login";
            ButtonLogin.UseVisualStyleBackColor = true;
            ButtonLogin.Click += ButtonLogin_Click;
            // 
            // CheckBoxShowPass
            // 
            CheckBoxShowPass.AutoSize = true;
            CheckBoxShowPass.Location = new Point(52, 192);
            CheckBoxShowPass.Name = "CheckBoxShowPass";
            CheckBoxShowPass.Size = new Size(101, 19);
            CheckBoxShowPass.TabIndex = 4;
            CheckBoxShowPass.Text = "Mostrar senha";
            CheckBoxShowPass.UseVisualStyleBackColor = true;
            CheckBoxShowPass.CheckedChanged += CheckBoxShowPass_CheckedChanged;
            // 
            // LblLogin
            // 
            LblLogin.AutoSize = true;
            LblLogin.Location = new Point(52, 89);
            LblLogin.Name = "LblLogin";
            LblLogin.Size = new Size(40, 15);
            LblLogin.TabIndex = 4;
            LblLogin.Text = "Login:";
            // 
            // LblSenha
            // 
            LblSenha.AutoSize = true;
            LblSenha.Location = new Point(52, 145);
            LblSenha.Name = "LblSenha";
            LblSenha.Size = new Size(42, 15);
            LblSenha.TabIndex = 5;
            LblSenha.Text = "Senha:";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { Strip });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(468, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // Strip
            // 
            Strip.DropDownItems.AddRange(new ToolStripItem[] { toolStripTextBox1 });
            Strip.Name = "Strip";
            Strip.Size = new Size(49, 20);
            Strip.Text = "Sobre";
            Strip.Click += Strip_Click;
            // 
            // toolStripTextBox1
            // 
            toolStripTextBox1.Name = "toolStripTextBox1";
            toolStripTextBox1.Size = new Size(100, 23);
            toolStripTextBox1.Click += toolStripTextBox1_Click;
            // 
            // TelaInicial
            // 
            AcceptButton = ButtonLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 366);
            Controls.Add(LblSenha);
            Controls.Add(LblLogin);
            Controls.Add(CheckBoxShowPass);
            Controls.Add(ButtonLogin);
            Controls.Add(TxtBSenha);
            Controls.Add(TxtBLogin);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(484, 405);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBLogin;
        private TextBox TxtBSenha;
        private Button ButtonLogin;
        private CheckBox CheckBoxShowPass;
        private Label LblLogin;
        private Label LblSenha;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Strip;
        private ToolStripTextBox toolStripTextBox1;
    }
}