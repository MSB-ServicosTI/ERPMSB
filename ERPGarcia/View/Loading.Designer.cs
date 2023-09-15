﻿namespace ERPGarcia.View
{
    partial class Loading
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading));
            loadingBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loadingBox).BeginInit();
            SuspendLayout();
            // 
            // loadingBox
            // 
            loadingBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loadingBox.Image = (Image)resources.GetObject("loadingBox.Image");
            loadingBox.Location = new Point(574, 298);
            loadingBox.Name = "loadingBox";
            loadingBox.Size = new Size(75, 77);
            loadingBox.TabIndex = 0;
            loadingBox.TabStop = false;
            // 
            // Loading
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1280, 700);
            Controls.Add(loadingBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Loading";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)loadingBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox loadingBox;
    }
}