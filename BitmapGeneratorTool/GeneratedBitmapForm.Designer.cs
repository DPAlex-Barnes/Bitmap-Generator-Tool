﻿namespace BitmapGeneratorTool
{
    partial class GeneratedBitmapForm
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
            this.GeneratedBitmapPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedBitmapPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneratedBitmapPictureBox
            // 
            this.GeneratedBitmapPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratedBitmapPictureBox.Location = new System.Drawing.Point(0, 0);
            this.GeneratedBitmapPictureBox.Name = "GeneratedBitmapPictureBox";
            this.GeneratedBitmapPictureBox.Size = new System.Drawing.Size(784, 561);
            this.GeneratedBitmapPictureBox.TabIndex = 0;
            this.GeneratedBitmapPictureBox.TabStop = false;
            // 
            // GeneratedBitmapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.GeneratedBitmapPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GeneratedBitmapForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneratedBitmapForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GeneratedBitmapForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GeneratedBitmapPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox GeneratedBitmapPictureBox;
    }
}