namespace FlipThisPic
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AngleNumberBox = new System.Windows.Forms.NumericUpDown();
            this.FlipHorizontallyCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FlipVerticallyCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SingleImageRadio = new System.Windows.Forms.RadioButton();
            this.ImageFolderRadio = new System.Windows.Forms.RadioButton();
            this.SingleImagePanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ImageOpenButton = new System.Windows.Forms.Button();
            this.ImagePathTextBox = new System.Windows.Forms.TextBox();
            this.SelectImageButton = new System.Windows.Forms.Button();
            this.ImageFolderPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FolderOpenButton = new System.Windows.Forms.Button();
            this.FolderPathTextBox = new System.Windows.Forms.TextBox();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.SaveToFolderTextBox = new System.Windows.Forms.TextBox();
            this.SaveToFolderRadio = new System.Windows.Forms.RadioButton();
            this.SaveOverwriteRadio = new System.Windows.Forms.RadioButton();
            this.SaveNewRadio = new System.Windows.Forms.RadioButton();
            this.SaveToFolderSelectButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.ImageSelectDialog = new System.Windows.Forms.OpenFileDialog();
            this.FolderDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.MainGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngleNumberBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SingleImagePanel.SuspendLayout();
            this.ImageFolderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.panel2);
            this.MainGroupBox.Controls.Add(this.panel1);
            this.MainGroupBox.Controls.Add(this.SaveToFolderTextBox);
            this.MainGroupBox.Controls.Add(this.SaveToFolderRadio);
            this.MainGroupBox.Controls.Add(this.SaveOverwriteRadio);
            this.MainGroupBox.Controls.Add(this.SaveNewRadio);
            this.MainGroupBox.Controls.Add(this.SaveToFolderSelectButton);
            this.MainGroupBox.Controls.Add(this.ConvertButton);
            this.MainGroupBox.Location = new System.Drawing.Point(9, 8);
            this.MainGroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.MainGroupBox.Size = new System.Drawing.Size(533, 218);
            this.MainGroupBox.TabIndex = 1;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Flip This";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AngleNumberBox);
            this.panel2.Controls.Add(this.FlipHorizontallyCheckBox);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.FlipVerticallyCheckBox);
            this.panel2.Location = new System.Drawing.Point(5, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 97);
            this.panel2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Degrees";
            // 
            // AngleNumberBox
            // 
            this.AngleNumberBox.Location = new System.Drawing.Point(80, 9);
            this.AngleNumberBox.Margin = new System.Windows.Forms.Padding(2);
            this.AngleNumberBox.Maximum = new decimal(new int[] {
            359,
            0,
            0,
            0});
            this.AngleNumberBox.Name = "AngleNumberBox";
            this.AngleNumberBox.Size = new System.Drawing.Size(50, 20);
            this.AngleNumberBox.TabIndex = 13;
            this.AngleNumberBox.Value = new decimal(new int[] {
            90,
            0,
            0,
            0});
            // 
            // FlipHorizontallyCheckBox
            // 
            this.FlipHorizontallyCheckBox.AutoSize = true;
            this.FlipHorizontallyCheckBox.Location = new System.Drawing.Point(31, 45);
            this.FlipHorizontallyCheckBox.Name = "FlipHorizontallyCheckBox";
            this.FlipHorizontallyCheckBox.Size = new System.Drawing.Size(99, 17);
            this.FlipHorizontallyCheckBox.TabIndex = 14;
            this.FlipHorizontallyCheckBox.Text = "Flip Horizontally";
            this.FlipHorizontallyCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FlipVerticallyCheckBox
            // 
            this.FlipVerticallyCheckBox.AutoSize = true;
            this.FlipVerticallyCheckBox.Location = new System.Drawing.Point(31, 66);
            this.FlipVerticallyCheckBox.Name = "FlipVerticallyCheckBox";
            this.FlipVerticallyCheckBox.Size = new System.Drawing.Size(87, 17);
            this.FlipVerticallyCheckBox.TabIndex = 14;
            this.FlipVerticallyCheckBox.Text = "Flip Vertically";
            this.FlipVerticallyCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.SingleImagePanel);
            this.panel1.Controls.Add(this.ImageFolderPanel);
            this.panel1.Location = new System.Drawing.Point(5, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 93);
            this.panel1.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SingleImageRadio);
            this.panel3.Controls.Add(this.ImageFolderRadio);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(99, 85);
            this.panel3.TabIndex = 21;
            // 
            // SingleImageRadio
            // 
            this.SingleImageRadio.AutoSize = true;
            this.SingleImageRadio.Location = new System.Drawing.Point(5, 10);
            this.SingleImageRadio.Name = "SingleImageRadio";
            this.SingleImageRadio.Size = new System.Drawing.Size(86, 17);
            this.SingleImageRadio.TabIndex = 18;
            this.SingleImageRadio.TabStop = true;
            this.SingleImageRadio.Text = "Single Image";
            this.SingleImageRadio.UseVisualStyleBackColor = true;
            this.SingleImageRadio.CheckedChanged += new System.EventHandler(this.SingleImageRadio_CheckedChanged);
            // 
            // ImageFolderRadio
            // 
            this.ImageFolderRadio.AutoSize = true;
            this.ImageFolderRadio.Location = new System.Drawing.Point(5, 57);
            this.ImageFolderRadio.Name = "ImageFolderRadio";
            this.ImageFolderRadio.Size = new System.Drawing.Size(86, 17);
            this.ImageFolderRadio.TabIndex = 19;
            this.ImageFolderRadio.TabStop = true;
            this.ImageFolderRadio.Text = "Image Folder";
            this.ImageFolderRadio.UseVisualStyleBackColor = true;
            this.ImageFolderRadio.CheckedChanged += new System.EventHandler(this.ImageFolderRadio_CheckedChanged);
            // 
            // SingleImagePanel
            // 
            this.SingleImagePanel.Controls.Add(this.label3);
            this.SingleImagePanel.Controls.Add(this.ImageOpenButton);
            this.SingleImagePanel.Controls.Add(this.ImagePathTextBox);
            this.SingleImagePanel.Controls.Add(this.SelectImageButton);
            this.SingleImagePanel.Location = new System.Drawing.Point(103, 3);
            this.SingleImagePanel.Name = "SingleImagePanel";
            this.SingleImagePanel.Padding = new System.Windows.Forms.Padding(3);
            this.SingleImagePanel.Size = new System.Drawing.Size(414, 38);
            this.SingleImagePanel.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Image";
            // 
            // ImageOpenButton
            // 
            this.ImageOpenButton.Location = new System.Drawing.Point(346, 7);
            this.ImageOpenButton.Name = "ImageOpenButton";
            this.ImageOpenButton.Size = new System.Drawing.Size(48, 23);
            this.ImageOpenButton.TabIndex = 17;
            this.ImageOpenButton.Text = "Open";
            this.ImageOpenButton.UseVisualStyleBackColor = true;
            this.ImageOpenButton.Click += new System.EventHandler(this.ImageOpenButton_Click);
            // 
            // ImagePathTextBox
            // 
            this.ImagePathTextBox.Enabled = false;
            this.ImagePathTextBox.Location = new System.Drawing.Point(110, 9);
            this.ImagePathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ImagePathTextBox.Name = "ImagePathTextBox";
            this.ImagePathTextBox.Size = new System.Drawing.Size(201, 20);
            this.ImagePathTextBox.TabIndex = 5;
            // 
            // SelectImageButton
            // 
            this.SelectImageButton.Location = new System.Drawing.Point(315, 8);
            this.SelectImageButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectImageButton.Name = "SelectImageButton";
            this.SelectImageButton.Size = new System.Drawing.Size(26, 21);
            this.SelectImageButton.TabIndex = 6;
            this.SelectImageButton.Text = "...";
            this.SelectImageButton.UseVisualStyleBackColor = true;
            this.SelectImageButton.Click += new System.EventHandler(this.SelectFilesButton_Click);
            // 
            // ImageFolderPanel
            // 
            this.ImageFolderPanel.Controls.Add(this.label2);
            this.ImageFolderPanel.Controls.Add(this.FolderOpenButton);
            this.ImageFolderPanel.Controls.Add(this.FolderPathTextBox);
            this.ImageFolderPanel.Controls.Add(this.SelectFolderButton);
            this.ImageFolderPanel.Enabled = false;
            this.ImageFolderPanel.Location = new System.Drawing.Point(103, 50);
            this.ImageFolderPanel.Name = "ImageFolderPanel";
            this.ImageFolderPanel.Padding = new System.Windows.Forms.Padding(3);
            this.ImageFolderPanel.Size = new System.Drawing.Size(414, 38);
            this.ImageFolderPanel.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Image Folder";
            // 
            // FolderOpenButton
            // 
            this.FolderOpenButton.Location = new System.Drawing.Point(346, 7);
            this.FolderOpenButton.Name = "FolderOpenButton";
            this.FolderOpenButton.Size = new System.Drawing.Size(48, 23);
            this.FolderOpenButton.TabIndex = 17;
            this.FolderOpenButton.Text = "Open";
            this.FolderOpenButton.UseVisualStyleBackColor = true;
            this.FolderOpenButton.Click += new System.EventHandler(this.FolderOpenButton_Click);
            // 
            // FolderPathTextBox
            // 
            this.FolderPathTextBox.Location = new System.Drawing.Point(110, 9);
            this.FolderPathTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.FolderPathTextBox.Name = "FolderPathTextBox";
            this.FolderPathTextBox.Size = new System.Drawing.Size(201, 20);
            this.FolderPathTextBox.TabIndex = 5;
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.Location = new System.Drawing.Point(315, 8);
            this.SelectFolderButton.Margin = new System.Windows.Forms.Padding(2);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(26, 21);
            this.SelectFolderButton.TabIndex = 6;
            this.SelectFolderButton.Text = "...";
            this.SelectFolderButton.UseVisualStyleBackColor = true;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // SaveToFolderTextBox
            // 
            this.SaveToFolderTextBox.Location = new System.Drawing.Point(191, 193);
            this.SaveToFolderTextBox.Name = "SaveToFolderTextBox";
            this.SaveToFolderTextBox.Size = new System.Drawing.Size(160, 20);
            this.SaveToFolderTextBox.TabIndex = 16;
            this.SaveToFolderTextBox.Visible = false;
            // 
            // SaveToFolderRadio
            // 
            this.SaveToFolderRadio.AutoSize = true;
            this.SaveToFolderRadio.Location = new System.Drawing.Point(191, 174);
            this.SaveToFolderRadio.Name = "SaveToFolderRadio";
            this.SaveToFolderRadio.Size = new System.Drawing.Size(98, 17);
            this.SaveToFolderRadio.TabIndex = 15;
            this.SaveToFolderRadio.TabStop = true;
            this.SaveToFolderRadio.Text = "Save To Folder";
            this.SaveToFolderRadio.UseVisualStyleBackColor = true;
            this.SaveToFolderRadio.CheckedChanged += new System.EventHandler(this.SaveToFolderRadio_CheckedChanged);
            // 
            // SaveOverwriteRadio
            // 
            this.SaveOverwriteRadio.AutoSize = true;
            this.SaveOverwriteRadio.Location = new System.Drawing.Point(191, 151);
            this.SaveOverwriteRadio.Name = "SaveOverwriteRadio";
            this.SaveOverwriteRadio.Size = new System.Drawing.Size(102, 17);
            this.SaveOverwriteRadio.TabIndex = 15;
            this.SaveOverwriteRadio.TabStop = true;
            this.SaveOverwriteRadio.Text = "Overwrite Image";
            this.SaveOverwriteRadio.UseVisualStyleBackColor = true;
            // 
            // SaveNewRadio
            // 
            this.SaveNewRadio.AutoSize = true;
            this.SaveNewRadio.Location = new System.Drawing.Point(191, 128);
            this.SaveNewRadio.Name = "SaveNewRadio";
            this.SaveNewRadio.Size = new System.Drawing.Size(122, 17);
            this.SaveNewRadio.TabIndex = 15;
            this.SaveNewRadio.TabStop = true;
            this.SaveNewRadio.Text = "Save As New Image";
            this.SaveNewRadio.UseVisualStyleBackColor = true;
            // 
            // SaveToFolderSelectButton
            // 
            this.SaveToFolderSelectButton.Location = new System.Drawing.Point(356, 193);
            this.SaveToFolderSelectButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveToFolderSelectButton.Name = "SaveToFolderSelectButton";
            this.SaveToFolderSelectButton.Size = new System.Drawing.Size(26, 21);
            this.SaveToFolderSelectButton.TabIndex = 6;
            this.SaveToFolderSelectButton.Text = "...";
            this.SaveToFolderSelectButton.UseVisualStyleBackColor = true;
            this.SaveToFolderSelectButton.Visible = false;
            this.SaveToFolderSelectButton.Click += new System.EventHandler(this.SaveToFolderShowButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ConvertButton.Location = new System.Drawing.Point(393, 117);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(2);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(136, 86);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Rotate";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // ImageSelectDialog
            // 
            this.ImageSelectDialog.Filter = "Images|*.jpg;*.jpeg;*.bmp;*.tiff;*.png;*.icon;*.ico;*.gif";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 237);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Flip this pic";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AngleNumberBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.SingleImagePanel.ResumeLayout(false);
            this.SingleImagePanel.PerformLayout();
            this.ImageFolderPanel.ResumeLayout(false);
            this.ImageFolderPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SelectImageButton;
        private System.Windows.Forms.TextBox ImagePathTextBox;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.NumericUpDown AngleNumberBox;
        private System.Windows.Forms.OpenFileDialog ImageSelectDialog;
        private System.Windows.Forms.CheckBox FlipVerticallyCheckBox;
        private System.Windows.Forms.CheckBox FlipHorizontallyCheckBox;
        private System.Windows.Forms.TextBox SaveToFolderTextBox;
        private System.Windows.Forms.RadioButton SaveToFolderRadio;
        private System.Windows.Forms.RadioButton SaveOverwriteRadio;
        private System.Windows.Forms.RadioButton SaveNewRadio;
        private System.Windows.Forms.Button SaveToFolderSelectButton;
        private System.Windows.Forms.Button ImageOpenButton;
        private System.Windows.Forms.RadioButton ImageFolderRadio;
        private System.Windows.Forms.Panel ImageFolderPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button FolderOpenButton;
        private System.Windows.Forms.TextBox FolderPathTextBox;
        private System.Windows.Forms.Button SelectFolderButton;
        private System.Windows.Forms.RadioButton SingleImageRadio;
        private System.Windows.Forms.Panel SingleImagePanel;
        private System.Windows.Forms.FolderBrowserDialog FolderDialog;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

