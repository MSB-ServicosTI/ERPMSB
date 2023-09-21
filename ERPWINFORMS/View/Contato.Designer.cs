namespace ERPWINFORMS.View
{
    partial class Contato
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
            lblContatoSuporte = new Label();
            lblContato = new Label();
            SuspendLayout();
            // 
            // lblContatoSuporte
            // 
            lblContatoSuporte.AutoSize = true;
            lblContatoSuporte.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblContatoSuporte.Location = new Point(12, 57);
            lblContatoSuporte.Name = "lblContatoSuporte";
            lblContatoSuporte.Size = new Size(223, 60);
            lblContatoSuporte.TabIndex = 0;
            lblContatoSuporte.Text = "Nosso endereço de E-mail é:\r\nsuporteerpmsb@outlook.com.br\r\nTelefone: (xx)xxxxx-xxxx";
            // 
            // lblContato
            // 
            lblContato.AutoSize = true;
            lblContato.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblContato.Location = new Point(12, 20);
            lblContato.Name = "lblContato";
            lblContato.Size = new Size(122, 25);
            lblContato.TabIndex = 1;
            lblContato.Text = "Contate-nos";
            // 
            // Contato
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(272, 144);
            Controls.Add(lblContato);
            Controls.Add(lblContatoSuporte);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Contato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suporte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContatoSuporte;
        private Label lblContato;
    }
}