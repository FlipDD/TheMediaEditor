namespace TheMediaEditor
{
    partial class DisplayView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplayView));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.picturePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SaveButton = new TheMediaEditor.CustomRoundButton();
            this.FilterButton = new TheMediaEditor.CustomRoundButton();
            this.ScaleButton = new TheMediaEditor.CustomRoundButton();
            this.label1 = new System.Windows.Forms.Label();
            this.separatingLine1 = new System.Windows.Forms.Label();
            this.separatingLine2 = new System.Windows.Forms.Label();
            this.ShowButton = new TheMediaEditor.CustomRoundButton();
            this.RotateButton = new TheMediaEditor.CustomRoundButton();
            this.CropButton = new TheMediaEditor.CustomRoundButton();
            this.FlipButton = new TheMediaEditor.CustomRoundButton();
            this.tableLayoutPanel.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.19192F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.80808F));
            this.tableLayoutPanel.Controls.Add(this.picturePanel, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(710, 537);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // picturePanel
            // 
            this.picturePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picturePanel.AutoSize = true;
            this.picturePanel.BackColor = System.Drawing.Color.DimGray;
            this.picturePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picturePanel.BackgroundImage")));
            this.picturePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picturePanel.Location = new System.Drawing.Point(136, 0);
            this.picturePanel.Margin = new System.Windows.Forms.Padding(0);
            this.picturePanel.Name = "picturePanel";
            this.picturePanel.Padding = new System.Windows.Forms.Padding(100);
            this.picturePanel.Size = new System.Drawing.Size(574, 537);
            this.picturePanel.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.SaveButton, 0, 11);
            this.tableLayoutPanel2.Controls.Add(this.FilterButton, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.ScaleButton, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.separatingLine1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.separatingLine2, 0, 10);
            this.tableLayoutPanel2.Controls.Add(this.ShowButton, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.RotateButton, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.CropButton, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.FlipButton, 0, 5);
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.MaximumSize = new System.Drawing.Size(200, 2000);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 12;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.579565F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.568205F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.445154F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.445154F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.524855F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.445154F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.520461F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.05848F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.03787F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.3751F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(130, 531);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.BorderColor = System.Drawing.Color.DimGray;
            this.SaveButton.ButtonColor = System.Drawing.Color.Black;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(16, 479);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.SaveButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.Size = new System.Drawing.Size(98, 44);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save";
            this.SaveButton.TextColor = System.Drawing.Color.White;
            this.SaveButton.UseVisualStyleBackColor = false;
            // 
            // FilterButton
            // 
            this.FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FilterButton.BorderColor = System.Drawing.Color.Black;
            this.FilterButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FilterButton.FlatAppearance.BorderSize = 0;
            this.FilterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FilterButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterButton.Location = new System.Drawing.Point(20, 265);
            this.FilterButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.FilterButton.Name = "FilterButton";
            this.FilterButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.FilterButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.FilterButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.FilterButton.Size = new System.Drawing.Size(90, 38);
            this.FilterButton.TabIndex = 6;
            this.FilterButton.Text = "Filters";
            this.FilterButton.TextColor = System.Drawing.Color.White;
            this.FilterButton.UseVisualStyleBackColor = false;
            this.FilterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // ScaleButton
            // 
            this.ScaleButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ScaleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScaleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ScaleButton.BorderColor = System.Drawing.Color.Black;
            this.ScaleButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScaleButton.FlatAppearance.BorderSize = 0;
            this.ScaleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScaleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScaleButton.Location = new System.Drawing.Point(20, 89);
            this.ScaleButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.ScaleButton.Name = "ScaleButton";
            this.ScaleButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ScaleButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.ScaleButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.ScaleButton.Size = new System.Drawing.Size(90, 38);
            this.ScaleButton.TabIndex = 7;
            this.ScaleButton.Text = "Scale";
            this.ScaleButton.TextColor = System.Drawing.Color.White;
            this.ScaleButton.UseVisualStyleBackColor = false;
            this.ScaleButton.Click += new System.EventHandler(this.ScaleButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tools";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // separatingLine1
            // 
            this.separatingLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatingLine1.AutoSize = true;
            this.separatingLine1.BackColor = System.Drawing.Color.Gray;
            this.separatingLine1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separatingLine1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.separatingLine1.Location = new System.Drawing.Point(12, 39);
            this.separatingLine1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.separatingLine1.Name = "separatingLine1";
            this.separatingLine1.Size = new System.Drawing.Size(106, 2);
            this.separatingLine1.TabIndex = 12;
            // 
            // separatingLine2
            // 
            this.separatingLine2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatingLine2.AutoSize = true;
            this.separatingLine2.BackColor = System.Drawing.Color.Gray;
            this.separatingLine2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.separatingLine2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.separatingLine2.Location = new System.Drawing.Point(12, 469);
            this.separatingLine2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.separatingLine2.Name = "separatingLine2";
            this.separatingLine2.Size = new System.Drawing.Size(106, 2);
            this.separatingLine2.TabIndex = 12;
            // 
            // ShowButton
            // 
            this.ShowButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShowButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShowButton.BorderColor = System.Drawing.Color.DimGray;
            this.ShowButton.ButtonColor = System.Drawing.Color.Black;
            this.ShowButton.FlatAppearance.BorderSize = 0;
            this.ShowButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowButton.Location = new System.Drawing.Point(16, 419);
            this.ShowButton.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ShowButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.ShowButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.ShowButton.Size = new System.Drawing.Size(98, 42);
            this.ShowButton.TabIndex = 9;
            this.ShowButton.Text = "Show Media";
            this.ShowButton.TextColor = System.Drawing.Color.White;
            this.ShowButton.UseVisualStyleBackColor = false;
            // 
            // RotateButton
            // 
            this.RotateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RotateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RotateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RotateButton.BorderColor = System.Drawing.Color.Black;
            this.RotateButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RotateButton.FlatAppearance.BorderSize = 0;
            this.RotateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RotateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RotateButton.Location = new System.Drawing.Point(20, 133);
            this.RotateButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.RotateButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.RotateButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.RotateButton.Size = new System.Drawing.Size(90, 38);
            this.RotateButton.TabIndex = 13;
            this.RotateButton.Text = "Rotate";
            this.RotateButton.TextColor = System.Drawing.Color.White;
            this.RotateButton.UseVisualStyleBackColor = false;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // CropButton
            // 
            this.CropButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CropButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CropButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CropButton.BorderColor = System.Drawing.Color.Black;
            this.CropButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CropButton.FlatAppearance.BorderSize = 0;
            this.CropButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CropButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CropButton.Location = new System.Drawing.Point(20, 221);
            this.CropButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.CropButton.Name = "CropButton";
            this.CropButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.CropButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.CropButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.CropButton.Size = new System.Drawing.Size(90, 38);
            this.CropButton.TabIndex = 8;
            this.CropButton.Text = "Crop";
            this.CropButton.TextColor = System.Drawing.Color.White;
            this.CropButton.UseVisualStyleBackColor = false;
            this.CropButton.Click += new System.EventHandler(this.CropButton_Click);
            // 
            // FlipButton
            // 
            this.FlipButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlipButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FlipButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FlipButton.BorderColor = System.Drawing.Color.Black;
            this.FlipButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FlipButton.FlatAppearance.BorderSize = 0;
            this.FlipButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlipButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FlipButton.Location = new System.Drawing.Point(20, 177);
            this.FlipButton.Margin = new System.Windows.Forms.Padding(20, 3, 20, 3);
            this.FlipButton.Name = "FlipButton";
            this.FlipButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.FlipButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.FlipButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.FlipButton.Size = new System.Drawing.Size(90, 38);
            this.FlipButton.TabIndex = 9;
            this.FlipButton.Text = "Flip";
            this.FlipButton.TextColor = System.Drawing.Color.White;
            this.FlipButton.UseVisualStyleBackColor = false;
            this.FlipButton.Click += new System.EventHandler(this.FlipButton_Click);
            // 
            // DisplayView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(734, 561);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(750, 600);
            this.Name = "DisplayView";
            this.Text = "Image Editor";
            this.Resize += new System.EventHandler(this.ImageViewer_Resize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Panel picturePanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustomRoundButton FilterButton;
        private CustomRoundButton FlipButton;
        private CustomRoundButton ScaleButton;
        private CustomRoundButton CropButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label separatingLine1;
        private System.Windows.Forms.Label separatingLine2;
        private CustomRoundButton SaveButton;
        private CustomRoundButton ShowButton;
        private CustomRoundButton RotateButton;
    }
}