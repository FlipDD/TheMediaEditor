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
            this.ToolsLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SaveButton = new TheMediaEditor.CustomRoundButton();
            this.ToolsLabel = new System.Windows.Forms.Label();
            this.separatingLine2 = new System.Windows.Forms.Label();
            this.RotationTrackBar = new System.Windows.Forms.TrackBar();
            this.RotateLabel = new System.Windows.Forms.Label();
            this.separatingLine1 = new System.Windows.Forms.Label();
            this.FlipLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.FlipHorizontalButton = new System.Windows.Forms.Button();
            this.FlipVerticalButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.WidthNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.HeightNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.BWButton = new TheMediaEditor.CustomRoundButton();
            this.OriginalButton = new TheMediaEditor.CustomRoundButton();
            this.InvertLabel = new System.Windows.Forms.Label();
            this.SepiaLabel = new System.Windows.Forms.Label();
            this.LomoLabel = new System.Windows.Forms.Label();
            this.ComicLabel = new System.Windows.Forms.Label();
            this.ResetButton = new TheMediaEditor.CustomRoundButton();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            this.ToolsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationTrackBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumUpDown)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
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
            this.tableLayoutPanel.Controls.Add(this.ToolsLayoutPanel, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.PictureBox, 1, 0);
            this.tableLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 1;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(860, 631);
            this.tableLayoutPanel.TabIndex = 5;
            // 
            // ToolsLayoutPanel
            // 
            this.ToolsLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolsLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ToolsLayoutPanel.ColumnCount = 1;
            this.ToolsLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ToolsLayoutPanel.Controls.Add(this.SaveButton, 0, 19);
            this.ToolsLayoutPanel.Controls.Add(this.ToolsLabel, 0, 0);
            this.ToolsLayoutPanel.Controls.Add(this.separatingLine2, 0, 18);
            this.ToolsLayoutPanel.Controls.Add(this.RotationTrackBar, 0, 9);
            this.ToolsLayoutPanel.Controls.Add(this.RotateLabel, 0, 7);
            this.ToolsLayoutPanel.Controls.Add(this.separatingLine1, 0, 10);
            this.ToolsLayoutPanel.Controls.Add(this.FlipLabel, 0, 11);
            this.ToolsLayoutPanel.Controls.Add(this.tableLayoutPanel1, 0, 12);
            this.ToolsLayoutPanel.Controls.Add(this.label7, 0, 13);
            this.ToolsLayoutPanel.Controls.Add(this.ValueLabel, 0, 8);
            this.ToolsLayoutPanel.Controls.Add(this.ScaleLabel, 0, 3);
            this.ToolsLayoutPanel.Controls.Add(this.tableLayoutPanel3, 0, 5);
            this.ToolsLayoutPanel.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.ToolsLayoutPanel.Controls.Add(this.label11, 0, 6);
            this.ToolsLayoutPanel.Controls.Add(this.label1, 0, 1);
            this.ToolsLayoutPanel.Controls.Add(this.label2, 0, 14);
            this.ToolsLayoutPanel.Controls.Add(this.tableLayoutPanel5, 0, 15);
            this.ToolsLayoutPanel.Controls.Add(this.ResetButton, 0, 16);
            this.ToolsLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ToolsLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ToolsLayoutPanel.MaximumSize = new System.Drawing.Size(200, 2000);
            this.ToolsLayoutPanel.Name = "ToolsLayoutPanel";
            this.ToolsLayoutPanel.RowCount = 20;
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.821839F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.784727F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.186637F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.588544F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.233295F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.047845F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.375456F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.083773F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.161913F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.882551F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.318335F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.7706F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.455284F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.203252F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.94951F));
            this.ToolsLayoutPanel.Size = new System.Drawing.Size(159, 625);
            this.ToolsLayoutPanel.TabIndex = 7;
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SaveButton.BorderColor = System.Drawing.Color.DimGray;
            this.SaveButton.ButtonColor = System.Drawing.Color.Black;
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(16, 560);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.SaveButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.Size = new System.Drawing.Size(127, 57);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save as...";
            this.SaveButton.TextColor = System.Drawing.Color.White;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ToolsLabel
            // 
            this.ToolsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolsLabel.AutoSize = true;
            this.ToolsLabel.BackColor = System.Drawing.Color.Transparent;
            this.ToolsLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolsLabel.ForeColor = System.Drawing.Color.White;
            this.ToolsLabel.Location = new System.Drawing.Point(3, 0);
            this.ToolsLabel.Name = "ToolsLabel";
            this.ToolsLabel.Size = new System.Drawing.Size(153, 54);
            this.ToolsLabel.TabIndex = 10;
            this.ToolsLabel.Text = "Tools";
            this.ToolsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.separatingLine2.Location = new System.Drawing.Point(12, 550);
            this.separatingLine2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.separatingLine2.Name = "separatingLine2";
            this.separatingLine2.Size = new System.Drawing.Size(135, 2);
            this.separatingLine2.TabIndex = 12;
            // 
            // RotationTrackBar
            // 
            this.RotationTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RotationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RotationTrackBar.Location = new System.Drawing.Point(0, 215);
            this.RotationTrackBar.Margin = new System.Windows.Forms.Padding(0, 4, 3, 8);
            this.RotationTrackBar.Maximum = 180;
            this.RotationTrackBar.Minimum = -180;
            this.RotationTrackBar.MinimumSize = new System.Drawing.Size(0, 15);
            this.RotationTrackBar.Name = "RotationTrackBar";
            this.RotationTrackBar.Size = new System.Drawing.Size(156, 19);
            this.RotationTrackBar.TabIndex = 15;
            this.RotationTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.RotationTrackBar.ValueChanged += new System.EventHandler(this.RotationTrackBar_ValueChanged);
            // 
            // RotateLabel
            // 
            this.RotateLabel.AutoSize = true;
            this.RotateLabel.BackColor = System.Drawing.Color.Transparent;
            this.RotateLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.RotateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.RotateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.RotateLabel.Location = new System.Drawing.Point(3, 176);
            this.RotateLabel.Name = "RotateLabel";
            this.RotateLabel.Size = new System.Drawing.Size(153, 21);
            this.RotateLabel.TabIndex = 16;
            this.RotateLabel.Text = "Rotate";
            this.RotateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.separatingLine1.Location = new System.Drawing.Point(32, 242);
            this.separatingLine1.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.separatingLine1.Name = "separatingLine1";
            this.separatingLine1.Size = new System.Drawing.Size(95, 2);
            this.separatingLine1.TabIndex = 12;
            // 
            // FlipLabel
            // 
            this.FlipLabel.AutoSize = true;
            this.FlipLabel.BackColor = System.Drawing.Color.Transparent;
            this.FlipLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlipLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FlipLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FlipLabel.Location = new System.Drawing.Point(3, 254);
            this.FlipLabel.Name = "FlipLabel";
            this.FlipLabel.Size = new System.Drawing.Size(153, 21);
            this.FlipLabel.TabIndex = 21;
            this.FlipLabel.Text = "Flip";
            this.FlipLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.FlipHorizontalButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.FlipVerticalButton, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 278);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(153, 36);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // FlipHorizontalButton
            // 
            this.FlipHorizontalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FlipHorizontalButton.BackgroundImage = global::TheMediaEditor.Properties.Resources.FlipHorizontalIcon;
            this.FlipHorizontalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlipHorizontalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlipHorizontalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlipHorizontalButton.Location = new System.Drawing.Point(12, 6);
            this.FlipHorizontalButton.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.FlipHorizontalButton.Name = "FlipHorizontalButton";
            this.FlipHorizontalButton.Size = new System.Drawing.Size(52, 24);
            this.FlipHorizontalButton.TabIndex = 0;
            this.FlipHorizontalButton.UseVisualStyleBackColor = false;
            this.FlipHorizontalButton.Click += new System.EventHandler(this.FlipHorizontalButton_Click);
            // 
            // FlipVerticalButton
            // 
            this.FlipVerticalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlipVerticalButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FlipVerticalButton.BackgroundImage = global::TheMediaEditor.Properties.Resources.FlipVerticalIcon;
            this.FlipVerticalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlipVerticalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FlipVerticalButton.Location = new System.Drawing.Point(88, 6);
            this.FlipVerticalButton.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.FlipVerticalButton.Name = "FlipVerticalButton";
            this.FlipVerticalButton.Size = new System.Drawing.Size(53, 24);
            this.FlipVerticalButton.TabIndex = 1;
            this.FlipVerticalButton.UseVisualStyleBackColor = false;
            this.FlipVerticalButton.Click += new System.EventHandler(this.FlipVerticalButton_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gray;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label7.Location = new System.Drawing.Point(32, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 2);
            this.label7.TabIndex = 23;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ValueLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.ForeColor = System.Drawing.Color.White;
            this.ValueLabel.Location = new System.Drawing.Point(3, 198);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(153, 13);
            this.ValueLabel.TabIndex = 17;
            this.ValueLabel.Text = "Value";
            this.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ScaleLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ScaleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ScaleLabel.Location = new System.Drawing.Point(3, 89);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(153, 21);
            this.ScaleLabel.TabIndex = 24;
            this.ScaleLabel.Text = "Scale";
            this.ScaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.WidthNumUpDown, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.HeightNumUpDown, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(153, 26);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // WidthNumUpDown
            // 
            this.WidthNumUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.WidthNumUpDown.Location = new System.Drawing.Point(12, 3);
            this.WidthNumUpDown.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.WidthNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNumUpDown.Name = "WidthNumUpDown";
            this.WidthNumUpDown.Size = new System.Drawing.Size(52, 20);
            this.WidthNumUpDown.TabIndex = 2;
            this.WidthNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthNumUpDown.ValueChanged += new System.EventHandler(this.WidthNumUpDown_ValueChanged);
            // 
            // HeightNumUpDown
            // 
            this.HeightNumUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.HeightNumUpDown.Location = new System.Drawing.Point(88, 3);
            this.HeightNumUpDown.Maximum = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.HeightNumUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNumUpDown.Name = "HeightNumUpDown";
            this.HeightNumUpDown.Size = new System.Drawing.Size(52, 20);
            this.HeightNumUpDown.TabIndex = 1;
            this.HeightNumUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HeightNumUpDown.ValueChanged += new System.EventHandler(this.HeightNumUpDown_ValueChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.HeightLabel, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.WidthLabel, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 113);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(153, 16);
            this.tableLayoutPanel4.TabIndex = 26;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeightLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HeightLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.ForeColor = System.Drawing.Color.White;
            this.HeightLabel.Location = new System.Drawing.Point(79, 3);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(71, 13);
            this.HeightLabel.TabIndex = 19;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.BackColor = System.Drawing.Color.Transparent;
            this.WidthLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.WidthLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WidthLabel.ForeColor = System.Drawing.Color.White;
            this.WidthLabel.Location = new System.Drawing.Point(3, 3);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(70, 13);
            this.WidthLabel.TabIndex = 18;
            this.WidthLabel.Text = "Width";
            this.WidthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gray;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label11.Location = new System.Drawing.Point(32, 164);
            this.label11.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 2);
            this.label11.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 2);
            this.label1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Filters";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.BWButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.OriginalButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.InvertLabel, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.SepiaLabel, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.LomoLabel, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.ComicLabel, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 354);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.70175F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.07018F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.10526F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(153, 109);
            this.tableLayoutPanel5.TabIndex = 31;
            // 
            // BWButton
            // 
            this.BWButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BWButton.BackColor = System.Drawing.Color.Transparent;
            this.BWButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BWButton.BorderColor = System.Drawing.Color.Gray;
            this.BWButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BWButton.FlatAppearance.BorderSize = 0;
            this.BWButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BWButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.BWButton.Location = new System.Drawing.Point(79, 3);
            this.BWButton.Name = "BWButton";
            this.BWButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BWButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.BWButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.BWButton.Size = new System.Drawing.Size(71, 27);
            this.BWButton.TabIndex = 33;
            this.BWButton.Text = "Black\'White";
            this.BWButton.TextColor = System.Drawing.Color.White;
            this.BWButton.UseVisualStyleBackColor = false;
            this.BWButton.Click += new System.EventHandler(this.BWButton_Click);
            // 
            // OriginalButton
            // 
            this.OriginalButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OriginalButton.BackColor = System.Drawing.Color.Transparent;
            this.OriginalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OriginalButton.BorderColor = System.Drawing.Color.Gray;
            this.OriginalButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.OriginalButton.FlatAppearance.BorderSize = 0;
            this.OriginalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OriginalButton.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.OriginalButton.Location = new System.Drawing.Point(3, 3);
            this.OriginalButton.Name = "OriginalButton";
            this.OriginalButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.OriginalButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.OriginalButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.OriginalButton.Size = new System.Drawing.Size(70, 27);
            this.OriginalButton.TabIndex = 32;
            this.OriginalButton.Text = "Original";
            this.OriginalButton.TextColor = System.Drawing.Color.White;
            this.OriginalButton.UseVisualStyleBackColor = false;
            // 
            // InvertLabel
            // 
            this.InvertLabel.AutoSize = true;
            this.InvertLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.InvertLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.InvertLabel.ForeColor = System.Drawing.Color.White;
            this.InvertLabel.Location = new System.Drawing.Point(79, 96);
            this.InvertLabel.Name = "InvertLabel";
            this.InvertLabel.Size = new System.Drawing.Size(71, 13);
            this.InvertLabel.TabIndex = 14;
            this.InvertLabel.Text = "Invert";
            this.InvertLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SepiaLabel
            // 
            this.SepiaLabel.AutoSize = true;
            this.SepiaLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SepiaLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.SepiaLabel.ForeColor = System.Drawing.Color.White;
            this.SepiaLabel.Location = new System.Drawing.Point(3, 96);
            this.SepiaLabel.Name = "SepiaLabel";
            this.SepiaLabel.Size = new System.Drawing.Size(70, 13);
            this.SepiaLabel.TabIndex = 13;
            this.SepiaLabel.Text = "Sepia";
            this.SepiaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LomoLabel
            // 
            this.LomoLabel.AutoSize = true;
            this.LomoLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.LomoLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.LomoLabel.ForeColor = System.Drawing.Color.White;
            this.LomoLabel.Location = new System.Drawing.Point(79, 50);
            this.LomoLabel.Name = "LomoLabel";
            this.LomoLabel.Size = new System.Drawing.Size(71, 13);
            this.LomoLabel.TabIndex = 12;
            this.LomoLabel.Text = "Lomography";
            this.LomoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComicLabel
            // 
            this.ComicLabel.AutoSize = true;
            this.ComicLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ComicLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic);
            this.ComicLabel.ForeColor = System.Drawing.Color.White;
            this.ComicLabel.Location = new System.Drawing.Point(3, 50);
            this.ComicLabel.Name = "ComicLabel";
            this.ComicLabel.Size = new System.Drawing.Size(70, 13);
            this.ComicLabel.TabIndex = 11;
            this.ComicLabel.Text = "Comic";
            this.ComicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ResetButton.BorderColor = System.Drawing.Color.DimGray;
            this.ResetButton.ButtonColor = System.Drawing.Color.Black;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(16, 474);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(16, 8, 16, 8);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ResetButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.ResetButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.ResetButton.Size = new System.Drawing.Size(127, 36);
            this.ResetButton.TabIndex = 32;
            this.ResetButton.Text = "Reset edits";
            this.ResetButton.TextColor = System.Drawing.Color.White;
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(168, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(689, 625);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox.TabIndex = 8;
            this.PictureBox.TabStop = false;
            // 
            // DisplayView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(884, 655);
            this.Controls.Add(this.tableLayoutPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(873, 657);
            this.Name = "DisplayView";
            this.Text = "Image Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DisplayView_FormClosing);
            this.Resize += new System.EventHandler(this.ImageViewer_Resize);
            this.tableLayoutPanel.ResumeLayout(false);
            this.ToolsLayoutPanel.ResumeLayout(false);
            this.ToolsLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationTrackBar)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumUpDown)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel ToolsLayoutPanel;
        private System.Windows.Forms.Label ToolsLabel;
        private System.Windows.Forms.Label separatingLine1;
        private System.Windows.Forms.Label separatingLine2;
        private CustomRoundButton SaveButton;
        private System.Windows.Forms.TrackBar RotationTrackBar;
        private System.Windows.Forms.Label RotateLabel;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label FlipLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button FlipHorizontalButton;
        private System.Windows.Forms.Button FlipVerticalButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown WidthNumUpDown;
        private System.Windows.Forms.NumericUpDown HeightNumUpDown;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox PictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label InvertLabel;
        private System.Windows.Forms.Label SepiaLabel;
        private System.Windows.Forms.Label LomoLabel;
        private System.Windows.Forms.Label ComicLabel;
        private CustomRoundButton OriginalButton;
        private CustomRoundButton BWButton;
        private CustomRoundButton ResetButton;
    }
}