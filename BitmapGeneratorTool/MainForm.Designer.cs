namespace BitmapGeneratorTool
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.DisplayButton = new System.Windows.Forms.Button();
            this.widthValueTextBox = new System.Windows.Forms.TextBox();
            this.heightValueTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.ResolutionGroupBox = new System.Windows.Forms.GroupBox();
            this.heightLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.redLowTextBox = new System.Windows.Forms.TextBox();
            this.redHighTextBox = new System.Windows.Forms.TextBox();
            this.greenLowTextBox = new System.Windows.Forms.TextBox();
            this.greenHighTextBox = new System.Windows.Forms.TextBox();
            this.blueLowTextBox = new System.Windows.Forms.TextBox();
            this.blueHighTextBox = new System.Windows.Forms.TextBox();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.setColourGroupBox = new System.Windows.Forms.GroupBox();
            this.flipColoursButton = new System.Windows.Forms.Button();
            this.ImportImageButton = new System.Windows.Forms.Button();
            this.ImportedImageOnePictureBox = new System.Windows.Forms.PictureBox();
            this.ImportedImageGroupBox = new System.Windows.Forms.GroupBox();
            this.ImportedImageFourPictureBox = new System.Windows.Forms.PictureBox();
            this.ImportedImageTwoPictureBox = new System.Windows.Forms.PictureBox();
            this.ImportedImageFivePictureBox = new System.Windows.Forms.PictureBox();
            this.ImportedImageThreePictureBox = new System.Windows.Forms.PictureBox();
            this.ImportedImageSixPictureBox = new System.Windows.Forms.PictureBox();
            this.ResolutionGroupBox.SuspendLayout();
            this.setColourGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageOnePictureBox)).BeginInit();
            this.ImportedImageGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageFourPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageTwoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageFivePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageThreePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageSixPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayButton
            // 
            this.DisplayButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.DisplayButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.DisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayButton.ForeColor = System.Drawing.Color.Navy;
            this.DisplayButton.Location = new System.Drawing.Point(395, 315);
            this.DisplayButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(182, 49);
            this.DisplayButton.TabIndex = 9;
            this.DisplayButton.Text = "Display";
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // widthValueTextBox
            // 
            this.widthValueTextBox.ForeColor = System.Drawing.Color.Navy;
            this.widthValueTextBox.Location = new System.Drawing.Point(138, 65);
            this.widthValueTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.widthValueTextBox.Name = "widthValueTextBox";
            this.widthValueTextBox.Size = new System.Drawing.Size(138, 35);
            this.widthValueTextBox.TabIndex = 1;
            this.widthValueTextBox.Text = "1920";
            // 
            // heightValueTextBox
            // 
            this.heightValueTextBox.ForeColor = System.Drawing.Color.Navy;
            this.heightValueTextBox.Location = new System.Drawing.Point(138, 122);
            this.heightValueTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.heightValueTextBox.Name = "heightValueTextBox";
            this.heightValueTextBox.Size = new System.Drawing.Size(138, 35);
            this.heightValueTextBox.TabIndex = 2;
            this.heightValueTextBox.Text = "1080";
            // 
            // ResetButton
            // 
            this.ResetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.ResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.ForeColor = System.Drawing.Color.Navy;
            this.ResetButton.Location = new System.Drawing.Point(29, 315);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(182, 49);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ResolutionGroupBox
            // 
            this.ResolutionGroupBox.Controls.Add(this.heightLabel);
            this.ResolutionGroupBox.Controls.Add(this.widthLabel);
            this.ResolutionGroupBox.Controls.Add(this.widthValueTextBox);
            this.ResolutionGroupBox.Controls.Add(this.heightValueTextBox);
            this.ResolutionGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.ResolutionGroupBox.Location = new System.Drawing.Point(29, 89);
            this.ResolutionGroupBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ResolutionGroupBox.Name = "ResolutionGroupBox";
            this.ResolutionGroupBox.Padding = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ResolutionGroupBox.Size = new System.Drawing.Size(321, 212);
            this.ResolutionGroupBox.TabIndex = 4;
            this.ResolutionGroupBox.TabStop = false;
            this.ResolutionGroupBox.Text = "Resolution";
            // 
            // heightLabel
            // 
            this.heightLabel.AutoSize = true;
            this.heightLabel.Location = new System.Drawing.Point(30, 124);
            this.heightLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.heightLabel.Name = "heightLabel";
            this.heightLabel.Size = new System.Drawing.Size(80, 30);
            this.heightLabel.TabIndex = 5;
            this.heightLabel.Text = "Height:";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(36, 67);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(74, 30);
            this.widthLabel.TabIndex = 4;
            this.widthLabel.Text = "Width:";
            // 
            // SaveButton
            // 
            this.SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.ForeColor = System.Drawing.Color.Navy;
            this.SaveButton.Location = new System.Drawing.Point(611, 315);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(182, 49);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.ForeColor = System.Drawing.Color.Red;
            this.redLabel.Location = new System.Drawing.Point(68, 45);
            this.redLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(48, 30);
            this.redLabel.TabIndex = 6;
            this.redLabel.Text = "Red";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.ForeColor = System.Drawing.Color.Green;
            this.greenLabel.Location = new System.Drawing.Point(164, 45);
            this.greenLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(68, 30);
            this.greenLabel.TabIndex = 7;
            this.greenLabel.Text = "Green";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.ForeColor = System.Drawing.Color.Blue;
            this.blueLabel.Location = new System.Drawing.Point(282, 45);
            this.blueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(53, 30);
            this.blueLabel.TabIndex = 8;
            this.blueLabel.Text = "Blue";
            // 
            // redLowTextBox
            // 
            this.redLowTextBox.ForeColor = System.Drawing.Color.Navy;
            this.redLowTextBox.Location = new System.Drawing.Point(56, 81);
            this.redLowTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.redLowTextBox.MaxLength = 10;
            this.redLowTextBox.Name = "redLowTextBox";
            this.redLowTextBox.Size = new System.Drawing.Size(74, 35);
            this.redLowTextBox.TabIndex = 3;
            this.redLowTextBox.Text = "0";
            // 
            // redHighTextBox
            // 
            this.redHighTextBox.ForeColor = System.Drawing.Color.Navy;
            this.redHighTextBox.Location = new System.Drawing.Point(56, 130);
            this.redHighTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.redHighTextBox.MaxLength = 10;
            this.redHighTextBox.Name = "redHighTextBox";
            this.redHighTextBox.Size = new System.Drawing.Size(74, 35);
            this.redHighTextBox.TabIndex = 4;
            this.redHighTextBox.Text = "255";
            // 
            // greenLowTextBox
            // 
            this.greenLowTextBox.ForeColor = System.Drawing.Color.Navy;
            this.greenLowTextBox.Location = new System.Drawing.Point(162, 81);
            this.greenLowTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.greenLowTextBox.MaxLength = 10;
            this.greenLowTextBox.Name = "greenLowTextBox";
            this.greenLowTextBox.Size = new System.Drawing.Size(74, 35);
            this.greenLowTextBox.TabIndex = 5;
            this.greenLowTextBox.Text = "0";
            // 
            // greenHighTextBox
            // 
            this.greenHighTextBox.ForeColor = System.Drawing.Color.Navy;
            this.greenHighTextBox.Location = new System.Drawing.Point(162, 130);
            this.greenHighTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.greenHighTextBox.MaxLength = 10;
            this.greenHighTextBox.Name = "greenHighTextBox";
            this.greenHighTextBox.Size = new System.Drawing.Size(72, 35);
            this.greenHighTextBox.TabIndex = 6;
            this.greenHighTextBox.Text = "255";
            // 
            // blueLowTextBox
            // 
            this.blueLowTextBox.ForeColor = System.Drawing.Color.Navy;
            this.blueLowTextBox.Location = new System.Drawing.Point(272, 81);
            this.blueLowTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.blueLowTextBox.MaxLength = 10;
            this.blueLowTextBox.Name = "blueLowTextBox";
            this.blueLowTextBox.Size = new System.Drawing.Size(74, 35);
            this.blueLowTextBox.TabIndex = 7;
            this.blueLowTextBox.Text = "0";
            // 
            // blueHighTextBox
            // 
            this.blueHighTextBox.ForeColor = System.Drawing.Color.Navy;
            this.blueHighTextBox.Location = new System.Drawing.Point(272, 130);
            this.blueHighTextBox.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.blueHighTextBox.MaxLength = 10;
            this.blueHighTextBox.Name = "blueHighTextBox";
            this.blueHighTextBox.Size = new System.Drawing.Size(74, 35);
            this.blueHighTextBox.TabIndex = 8;
            this.blueHighTextBox.Text = "255";
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.Navy;
            this.HeaderLabel.Location = new System.Drawing.Point(39, 27);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(266, 37);
            this.HeaderLabel.TabIndex = 15;
            this.HeaderLabel.Text = "8bit Bitmap Tool";
            // 
            // setColourGroupBox
            // 
            this.setColourGroupBox.Controls.Add(this.flipColoursButton);
            this.setColourGroupBox.Controls.Add(this.blueHighTextBox);
            this.setColourGroupBox.Controls.Add(this.blueLowTextBox);
            this.setColourGroupBox.Controls.Add(this.greenHighTextBox);
            this.setColourGroupBox.Controls.Add(this.greenLowTextBox);
            this.setColourGroupBox.Controls.Add(this.redHighTextBox);
            this.setColourGroupBox.Controls.Add(this.redLowTextBox);
            this.setColourGroupBox.Controls.Add(this.blueLabel);
            this.setColourGroupBox.Controls.Add(this.greenLabel);
            this.setColourGroupBox.Controls.Add(this.redLabel);
            this.setColourGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.setColourGroupBox.Location = new System.Drawing.Point(397, 89);
            this.setColourGroupBox.Name = "setColourGroupBox";
            this.setColourGroupBox.Size = new System.Drawing.Size(398, 212);
            this.setColourGroupBox.TabIndex = 16;
            this.setColourGroupBox.TabStop = false;
            this.setColourGroupBox.Text = "Set Colour";
            // 
            // flipColoursButton
            // 
            this.flipColoursButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.flipColoursButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.flipColoursButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flipColoursButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipColoursButton.ForeColor = System.Drawing.Color.Navy;
            this.flipColoursButton.Location = new System.Drawing.Point(352, 108);
            this.flipColoursButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.flipColoursButton.Name = "flipColoursButton";
            this.flipColoursButton.Size = new System.Drawing.Size(37, 29);
            this.flipColoursButton.TabIndex = 17;
            this.flipColoursButton.Text = "🗘";
            this.flipColoursButton.UseVisualStyleBackColor = true;
            this.flipColoursButton.Click += new System.EventHandler(this.flipColoursButton_Click);
            // 
            // ImportImageButton
            // 
            this.ImportImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(130)))), ((int)(((byte)(230)))));
            this.ImportImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.ImportImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ImportImageButton.ForeColor = System.Drawing.Color.Navy;
            this.ImportImageButton.Location = new System.Drawing.Point(397, 23);
            this.ImportImageButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.ImportImageButton.Name = "ImportImageButton";
            this.ImportImageButton.Size = new System.Drawing.Size(398, 49);
            this.ImportImageButton.TabIndex = 17;
            this.ImportImageButton.Text = "Import Image...";
            this.ImportImageButton.UseVisualStyleBackColor = true;
            this.ImportImageButton.Click += new System.EventHandler(this.ImportImageButton_Click);
            // 
            // ImportedImageOnePictureBox
            // 
            this.ImportedImageOnePictureBox.Location = new System.Drawing.Point(38, 36);
            this.ImportedImageOnePictureBox.Name = "ImportedImageOnePictureBox";
            this.ImportedImageOnePictureBox.Size = new System.Drawing.Size(100, 75);
            this.ImportedImageOnePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImportedImageOnePictureBox.TabIndex = 18;
            this.ImportedImageOnePictureBox.TabStop = false;
            // 
            // ImportedImageGroupBox
            // 
            this.ImportedImageGroupBox.Controls.Add(this.ImportedImageSixPictureBox);
            this.ImportedImageGroupBox.Controls.Add(this.ImportedImageThreePictureBox);
            this.ImportedImageGroupBox.Controls.Add(this.ImportedImageFivePictureBox);
            this.ImportedImageGroupBox.Controls.Add(this.ImportedImageFourPictureBox);
            this.ImportedImageGroupBox.Controls.Add(this.ImportedImageOnePictureBox);
            this.ImportedImageGroupBox.Controls.Add(this.ImportedImageTwoPictureBox);
            this.ImportedImageGroupBox.ForeColor = System.Drawing.Color.Navy;
            this.ImportedImageGroupBox.Location = new System.Drawing.Point(397, 89);
            this.ImportedImageGroupBox.Name = "ImportedImageGroupBox";
            this.ImportedImageGroupBox.Size = new System.Drawing.Size(398, 212);
            this.ImportedImageGroupBox.TabIndex = 18;
            this.ImportedImageGroupBox.TabStop = false;
            this.ImportedImageGroupBox.Text = "Imported Image";
            this.ImportedImageGroupBox.Visible = false;
            // 
            // ImportedImageFourPictureBox
            // 
            this.ImportedImageFourPictureBox.Location = new System.Drawing.Point(38, 120);
            this.ImportedImageFourPictureBox.Name = "ImportedImageFourPictureBox";
            this.ImportedImageFourPictureBox.Size = new System.Drawing.Size(100, 75);
            this.ImportedImageFourPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImportedImageFourPictureBox.TabIndex = 19;
            this.ImportedImageFourPictureBox.TabStop = false;
            // 
            // ImportedImageTwoPictureBox
            // 
            this.ImportedImageTwoPictureBox.Location = new System.Drawing.Point(150, 36);
            this.ImportedImageTwoPictureBox.Name = "ImportedImageTwoPictureBox";
            this.ImportedImageTwoPictureBox.Size = new System.Drawing.Size(100, 75);
            this.ImportedImageTwoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImportedImageTwoPictureBox.TabIndex = 20;
            this.ImportedImageTwoPictureBox.TabStop = false;
            // 
            // ImportedImageFivePictureBox
            // 
            this.ImportedImageFivePictureBox.Location = new System.Drawing.Point(150, 120);
            this.ImportedImageFivePictureBox.Name = "ImportedImageFivePictureBox";
            this.ImportedImageFivePictureBox.Size = new System.Drawing.Size(100, 75);
            this.ImportedImageFivePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImportedImageFivePictureBox.TabIndex = 21;
            this.ImportedImageFivePictureBox.TabStop = false;
            // 
            // ImportedImageThreePictureBox
            // 
            this.ImportedImageThreePictureBox.Location = new System.Drawing.Point(262, 36);
            this.ImportedImageThreePictureBox.Name = "ImportedImageThreePictureBox";
            this.ImportedImageThreePictureBox.Size = new System.Drawing.Size(100, 75);
            this.ImportedImageThreePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImportedImageThreePictureBox.TabIndex = 22;
            this.ImportedImageThreePictureBox.TabStop = false;
            // 
            // ImportedImageSixPictureBox
            // 
            this.ImportedImageSixPictureBox.Location = new System.Drawing.Point(262, 120);
            this.ImportedImageSixPictureBox.Name = "ImportedImageSixPictureBox";
            this.ImportedImageSixPictureBox.Size = new System.Drawing.Size(100, 75);
            this.ImportedImageSixPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImportedImageSixPictureBox.TabIndex = 23;
            this.ImportedImageSixPictureBox.TabStop = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(825, 394);
            this.Controls.Add(this.ImportImageButton);
            this.Controls.Add(this.HeaderLabel);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.ResolutionGroupBox);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.ImportedImageGroupBox);
            this.Controls.Add(this.setColourGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "mainForm";
            this.Text = "Bitmap Tool";
            this.ResolutionGroupBox.ResumeLayout(false);
            this.ResolutionGroupBox.PerformLayout();
            this.setColourGroupBox.ResumeLayout(false);
            this.setColourGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageOnePictureBox)).EndInit();
            this.ImportedImageGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageFourPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageTwoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageFivePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageThreePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImportedImageSixPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.TextBox widthValueTextBox;
        private System.Windows.Forms.TextBox heightValueTextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.GroupBox ResolutionGroupBox;
        private System.Windows.Forms.Label heightLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label redLabel;
        private System.Windows.Forms.Label greenLabel;
        private System.Windows.Forms.Label blueLabel;
        private System.Windows.Forms.TextBox redLowTextBox;
        private System.Windows.Forms.TextBox redHighTextBox;
        private System.Windows.Forms.TextBox greenLowTextBox;
        private System.Windows.Forms.TextBox greenHighTextBox;
        private System.Windows.Forms.TextBox blueLowTextBox;
        private System.Windows.Forms.TextBox blueHighTextBox;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.GroupBox setColourGroupBox;
        private System.Windows.Forms.Button flipColoursButton;
        private System.Windows.Forms.Button ImportImageButton;
        private System.Windows.Forms.PictureBox ImportedImageOnePictureBox;
        private System.Windows.Forms.GroupBox ImportedImageGroupBox;
        private System.Windows.Forms.PictureBox ImportedImageSixPictureBox;
        private System.Windows.Forms.PictureBox ImportedImageThreePictureBox;
        private System.Windows.Forms.PictureBox ImportedImageFivePictureBox;
        private System.Windows.Forms.PictureBox ImportedImageTwoPictureBox;
        private System.Windows.Forms.PictureBox ImportedImageFourPictureBox;
    }
}

