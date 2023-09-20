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
            btnLogin = new Button();
            CheckBoxShowPass = new CheckBox();
            LblLogin = new Label();
            LblSenha = new Label();
            menuStrip = new MenuStrip();
            tsmiSobre = new ToolStripMenuItem();
            btnSair = new Button();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // TxtBLogin
            // 
            TxtBLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBLogin.Cursor = Cursors.IBeam;
            TxtBLogin.Location = new Point(52, 107);
            TxtBLogin.Name = "TxtBLogin";
            TxtBLogin.PlaceholderText = "Insira seu Login aqui";
            TxtBLogin.Size = new Size(386, 23);
            TxtBLogin.TabIndex = 0;
            // 
            // TxtBSenha
            // 
            TxtBSenha.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TxtBSenha.Cursor = Cursors.IBeam;
            TxtBSenha.Location = new Point(52, 163);
            TxtBSenha.Name = "TxtBSenha";
            TxtBSenha.PlaceholderText = "Insira sua Senha aqui";
            TxtBSenha.Size = new Size(386, 23);
            TxtBSenha.TabIndex = 1;
            TxtBSenha.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.DimGray;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.Location = new Point(282, 217);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 0;
            btnLogin.TabStop = false;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += ButtonLogin_Click;
            // 
            // CheckBoxShowPass
            // 
            CheckBoxShowPass.AutoSize = true;
            CheckBoxShowPass.Location = new Point(52, 192);
            CheckBoxShowPass.Name = "CheckBoxShowPass";
            CheckBoxShowPass.Size = new Size(101, 19);
            CheckBoxShowPass.TabIndex = 2;
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
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { tsmiSobre });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(496, 24);
            menuStrip.TabIndex = 6;
            menuStrip.Text = "menuStrip1";
            // 
            // tsmiSobre
            // 
            tsmiSobre.Name = "tsmiSobre";
            tsmiSobre.Size = new Size(49, 20);
            tsmiSobre.Text = "Sobre";
            tsmiSobre.Click += sobreToolStripMenuItem_Click;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnSair.Cursor = Cursors.Hand;
            btnSair.FlatAppearance.BorderColor = Color.DimGray;
            btnSair.Location = new Point(372, 217);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 0;
            btnSair.TabStop = false;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // TelaInicial
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            ClientSize = new Size(496, 325);
            Controls.Add(btnSair);
            Controls.Add(LblSenha);
            Controls.Add(LblLogin);
            Controls.Add(CheckBoxShowPass);
            Controls.Add(btnLogin);
            Controls.Add(TxtBSenha);
            Controls.Add(TxtBLogin);
            Controls.Add(menuStrip);
            Cursor = Cursors.Default;
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.On;
            MainMenuStrip = menuStrip;
            MaximizeBox = false;
            MaximumSize = new Size(800, 900);
            MinimizeBox = false;
            MinimumSize = new Size(484, 0);
            Name = "TelaInicial";
            StartPosition = FormStartPosition.CenterScreen;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtBLogin;
        private TextBox TxtBSenha;
        private Button btnLogin;
        private Button btnSair;
        private CheckBox CheckBoxShowPass;
        private Label LblLogin;
        private Label LblSenha;
        private MenuStrip menuStrip;
        private ToolStripMenuItem tsmiSobre;
        private Label label1;
    }
}