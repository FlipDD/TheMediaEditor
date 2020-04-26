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
            this.ConstrastLabel = new System.Windows.Forms.Label();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.SaturationTrackBar = new System.Windows.Forms.TrackBar();
            this.SaturationLabel = new System.Windows.Forms.Label();
            this.PictureBox = new System.Windows.Forms.PictureBox();
            this.SaveButton = new TheMediaEditor.CustomRoundButton();
            this.OriginalButton = new TheMediaEditor.CustomRoundButton();
            this.BWButton = new TheMediaEditor.CustomRoundButton();
            this.ComicButton = new TheMediaEditor.CustomRoundButton();
            this.LomoButton = new TheMediaEditor.CustomRoundButton();
            this.SepiaButton = new TheMediaEditor.CustomRoundButton();
            this.InvertButton = new TheMediaEditor.CustomRoundButton();
            this.ResetButton = new TheMediaEditor.CustomRoundButton();
            this.tableLayoutPanel.SuspendLayout();
            this.ToolsLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationTrackBar)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WidthNumUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeightNumUpDown)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).BeginInit();
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
            this.tableLayoutPanel.Size = new System.Drawing.Size(884, 638);
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
            this.ToolsLayoutPanel.Controls.Add(this.SaveButton, 0, 26);
            this.ToolsLayoutPanel.Controls.Add(this.ToolsLabel, 0, 0);
            this.ToolsLayoutPanel.Controls.Add(this.separatingLine2, 0, 25);
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
            this.ToolsLayoutPanel.Controls.Add(this.ResetButton, 0, 23);
            this.ToolsLayoutPanel.Controls.Add(this.ConstrastLabel, 0, 17);
            this.ToolsLayoutPanel.Controls.Add(this.ContrastTrackBar, 0, 18);
            this.ToolsLayoutPanel.Controls.Add(this.label3, 0, 16);
            this.ToolsLayoutPanel.Controls.Add(this.BrightnessLabel, 0, 19);
            this.ToolsLayoutPanel.Controls.Add(this.BrightnessTrackBar, 0, 20);
            this.ToolsLayoutPanel.Controls.Add(this.SaturationTrackBar, 0, 22);
            this.ToolsLayoutPanel.Controls.Add(this.SaturationLabel, 0, 21);
            this.ToolsLayoutPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.ToolsLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.ToolsLayoutPanel.MaximumSize = new System.Drawing.Size(200, 2000);
            this.ToolsLayoutPanel.Name = "ToolsLayoutPanel";
            this.ToolsLayoutPanel.RowCount = 27;
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.246387F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.131345F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.93479F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.93479F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.410336F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.26269F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.295295F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.09874F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.09874F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.557984F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.370213F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.13949F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.979572F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.979572F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.979572F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.979572F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.979572F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.979572F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.98613F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 1.289734F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.ToolsLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.365915F));
            this.ToolsLayoutPanel.Size = new System.Drawing.Size(163, 632);
            this.ToolsLayoutPanel.TabIndex = 7;
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
            this.ToolsLabel.Size = new System.Drawing.Size(157, 32);
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
            this.separatingLine2.Location = new System.Drawing.Point(12, 574);
            this.separatingLine2.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.separatingLine2.Name = "separatingLine2";
            this.separatingLine2.Size = new System.Drawing.Size(139, 2);
            this.separatingLine2.TabIndex = 12;
            // 
            // RotationTrackBar
            // 
            this.RotationTrackBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.RotationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RotationTrackBar.Location = new System.Drawing.Point(0, 174);
            this.RotationTrackBar.Margin = new System.Windows.Forms.Padding(0, 4, 3, 8);
            this.RotationTrackBar.Maximum = 180;
            this.RotationTrackBar.Minimum = -180;
            this.RotationTrackBar.MinimumSize = new System.Drawing.Size(0, 15);
            this.RotationTrackBar.Name = "RotationTrackBar";
            this.RotationTrackBar.Size = new System.Drawing.Size(160, 15);
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
            this.RotateLabel.Location = new System.Drawing.Point(3, 135);
            this.RotateLabel.Name = "RotateLabel";
            this.RotateLabel.Size = new System.Drawing.Size(157, 21);
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
            this.separatingLine1.Location = new System.Drawing.Point(32, 195);
            this.separatingLine1.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.separatingLine1.Name = "separatingLine1";
            this.separatingLine1.Size = new System.Drawing.Size(99, 2);
            this.separatingLine1.TabIndex = 12;
            // 
            // FlipLabel
            // 
            this.FlipLabel.AutoSize = true;
            this.FlipLabel.BackColor = System.Drawing.Color.Transparent;
            this.FlipLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.FlipLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.FlipLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.FlipLabel.Location = new System.Drawing.Point(3, 201);
            this.FlipLabel.Name = "FlipLabel";
            this.FlipLabel.Size = new System.Drawing.Size(157, 21);
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 225);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(157, 34);
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
            this.FlipHorizontalButton.Size = new System.Drawing.Size(54, 22);
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
            this.FlipVerticalButton.Location = new System.Drawing.Point(90, 6);
            this.FlipVerticalButton.Margin = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.FlipVerticalButton.Name = "FlipVerticalButton";
            this.FlipVerticalButton.Size = new System.Drawing.Size(55, 22);
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
            this.label7.Location = new System.Drawing.Point(32, 262);
            this.label7.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 2);
            this.label7.TabIndex = 23;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.ValueLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ValueLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLabel.ForeColor = System.Drawing.Color.White;
            this.ValueLabel.Location = new System.Drawing.Point(3, 157);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(157, 13);
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
            this.ScaleLabel.Location = new System.Drawing.Point(3, 50);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(157, 21);
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
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 98);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(157, 27);
            this.tableLayoutPanel3.TabIndex = 25;
            // 
            // WidthNumUpDown
            // 
            this.WidthNumUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.WidthNumUpDown.Location = new System.Drawing.Point(13, 3);
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
            this.HeightNumUpDown.Location = new System.Drawing.Point(91, 3);
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
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 74);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(157, 18);
            this.tableLayoutPanel4.TabIndex = 26;
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.BackColor = System.Drawing.Color.Transparent;
            this.HeightLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HeightLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeightLabel.ForeColor = System.Drawing.Color.White;
            this.HeightLabel.Location = new System.Drawing.Point(81, 5);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(73, 13);
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
            this.WidthLabel.Location = new System.Drawing.Point(3, 5);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(72, 13);
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
            this.label11.Location = new System.Drawing.Point(32, 128);
            this.label11.Margin = new System.Windows.Forms.Padding(32, 0, 32, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(99, 2);
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
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 2);
            this.label1.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(3, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Filters";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel5.Controls.Add(this.OriginalButton, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.BWButton, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ComicButton, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.LomoButton, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.SepiaButton, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.InvertButton, 2, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 294);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(157, 69);
            this.tableLayoutPanel5.TabIndex = 31;
            // 
            // ConstrastLabel
            // 
            this.ConstrastLabel.AutoSize = true;
            this.ConstrastLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ConstrastLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ConstrastLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ConstrastLabel.Location = new System.Drawing.Point(3, 371);
            this.ConstrastLabel.Name = "ConstrastLabel";
            this.ConstrastLabel.Size = new System.Drawing.Size(157, 21);
            this.ConstrastLabel.TabIndex = 33;
            this.ConstrastLabel.Text = "Contrast";
            this.ConstrastLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContrastTrackBar.Location = new System.Drawing.Point(3, 395);
            this.ContrastTrackBar.Maximum = 100;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(157, 18);
            this.ContrastTrackBar.TabIndex = 34;
            this.ContrastTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.ContrastTrackBar.ValueChanged += new System.EventHandler(this.ContrastTrackBar_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gray;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(12, 366);
            this.label3.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 2);
            this.label3.TabIndex = 35;
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BrightnessLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.BrightnessLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.BrightnessLabel.Location = new System.Drawing.Point(3, 419);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(157, 21);
            this.BrightnessLabel.TabIndex = 36;
            this.BrightnessLabel.Text = "Brightness";
            this.BrightnessLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrightnessTrackBar.Location = new System.Drawing.Point(3, 443);
            this.BrightnessTrackBar.Maximum = 100;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(157, 18);
            this.BrightnessTrackBar.TabIndex = 37;
            this.BrightnessTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.BrightnessTrackBar.ValueChanged += new System.EventHandler(this.BrightnessTrackBar_ValueChanged);
            // 
            // SaturationTrackBar
            // 
            this.SaturationTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SaturationTrackBar.Location = new System.Drawing.Point(3, 491);
            this.SaturationTrackBar.Maximum = 100;
            this.SaturationTrackBar.Name = "SaturationTrackBar";
            this.SaturationTrackBar.Size = new System.Drawing.Size(157, 18);
            this.SaturationTrackBar.TabIndex = 38;
            this.SaturationTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SaturationTrackBar.ValueChanged += new System.EventHandler(this.SaturationTrackBar_ValueChanged);
            // 
            // SaturationLabel
            // 
            this.SaturationLabel.AutoSize = true;
            this.SaturationLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.SaturationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.SaturationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SaturationLabel.Location = new System.Drawing.Point(3, 467);
            this.SaturationLabel.Name = "SaturationLabel";
            this.SaturationLabel.Size = new System.Drawing.Size(157, 21);
            this.SaturationLabel.TabIndex = 39;
            this.SaturationLabel.Text = "Saturation";
            this.SaturationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PictureBox
            // 
            this.PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
            this.PictureBox.Location = new System.Drawing.Point(172, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Size = new System.Drawing.Size(709, 632);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBox.TabIndex = 8;
            this.PictureBox.TabStop = false;
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
            this.SaveButton.Location = new System.Drawing.Point(30, 584);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(30, 8, 30, 8);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.SaveButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.SaveButton.Size = new System.Drawing.Size(103, 40);
            this.SaveButton.TabIndex = 10;
            this.SaveButton.Text = "Save as...";
            this.SaveButton.TextColor = System.Drawing.Color.White;
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
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
            this.OriginalButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.OriginalButton.Location = new System.Drawing.Point(3, 3);
            this.OriginalButton.Name = "OriginalButton";
            this.OriginalButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.OriginalButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.OriginalButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.OriginalButton.Size = new System.Drawing.Size(46, 28);
            this.OriginalButton.TabIndex = 32;
            this.OriginalButton.Text = "Original";
            this.OriginalButton.TextColor = System.Drawing.Color.White;
            this.OriginalButton.UseVisualStyleBackColor = false;
            this.OriginalButton.Click += new System.EventHandler(this.OriginalButton_Click);
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
            this.BWButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.BWButton.Location = new System.Drawing.Point(55, 3);
            this.BWButton.Name = "BWButton";
            this.BWButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.BWButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.BWButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.BWButton.Size = new System.Drawing.Size(46, 28);
            this.BWButton.TabIndex = 33;
            this.BWButton.Text = "BW";
            this.BWButton.TextColor = System.Drawing.Color.White;
            this.BWButton.UseVisualStyleBackColor = false;
            this.BWButton.Click += new System.EventHandler(this.BWButton_Click);
            // 
            // ComicButton
            // 
            this.ComicButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComicButton.BackColor = System.Drawing.Color.Transparent;
            this.ComicButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ComicButton.BorderColor = System.Drawing.Color.Gray;
            this.ComicButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ComicButton.FlatAppearance.BorderSize = 0;
            this.ComicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComicButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.ComicButton.Location = new System.Drawing.Point(107, 3);
            this.ComicButton.Name = "ComicButton";
            this.ComicButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ComicButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.ComicButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.ComicButton.Size = new System.Drawing.Size(47, 28);
            this.ComicButton.TabIndex = 34;
            this.ComicButton.Text = "Comic";
            this.ComicButton.TextColor = System.Drawing.Color.White;
            this.ComicButton.UseVisualStyleBackColor = false;
            this.ComicButton.Click += new System.EventHandler(this.ComicButton_Click);
            // 
            // LomoButton
            // 
            this.LomoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LomoButton.BackColor = System.Drawing.Color.Transparent;
            this.LomoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LomoButton.BorderColor = System.Drawing.Color.Gray;
            this.LomoButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LomoButton.FlatAppearance.BorderSize = 0;
            this.LomoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LomoButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.LomoButton.Location = new System.Drawing.Point(3, 37);
            this.LomoButton.Name = "LomoButton";
            this.LomoButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.LomoButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.LomoButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.LomoButton.Size = new System.Drawing.Size(46, 29);
            this.LomoButton.TabIndex = 35;
            this.LomoButton.Text = "Lomo";
            this.LomoButton.TextColor = System.Drawing.Color.White;
            this.LomoButton.UseVisualStyleBackColor = false;
            this.LomoButton.Click += new System.EventHandler(this.LomoButton_Click);
            // 
            // SepiaButton
            // 
            this.SepiaButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SepiaButton.BackColor = System.Drawing.Color.Transparent;
            this.SepiaButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SepiaButton.BorderColor = System.Drawing.Color.Gray;
            this.SepiaButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.SepiaButton.FlatAppearance.BorderSize = 0;
            this.SepiaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SepiaButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.SepiaButton.Location = new System.Drawing.Point(55, 37);
            this.SepiaButton.Name = "SepiaButton";
            this.SepiaButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.SepiaButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.SepiaButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.SepiaButton.Size = new System.Drawing.Size(46, 29);
            this.SepiaButton.TabIndex = 36;
            this.SepiaButton.Text = "Sepia";
            this.SepiaButton.TextColor = System.Drawing.Color.White;
            this.SepiaButton.UseVisualStyleBackColor = false;
            this.SepiaButton.Click += new System.EventHandler(this.SepiaButton_Click);
            // 
            // InvertButton
            // 
            this.InvertButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InvertButton.BackColor = System.Drawing.Color.Transparent;
            this.InvertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.InvertButton.BorderColor = System.Drawing.Color.Gray;
            this.InvertButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.InvertButton.FlatAppearance.BorderSize = 0;
            this.InvertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InvertButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.InvertButton.Location = new System.Drawing.Point(107, 37);
            this.InvertButton.Name = "InvertButton";
            this.InvertButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.InvertButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.InvertButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.InvertButton.Size = new System.Drawing.Size(47, 29);
            this.InvertButton.TabIndex = 37;
            this.InvertButton.Text = "Invert";
            this.InvertButton.TextColor = System.Drawing.Color.White;
            this.InvertButton.UseVisualStyleBackColor = false;
            this.InvertButton.Click += new System.EventHandler(this.InvertButton_Click);
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
            this.ResetButton.Location = new System.Drawing.Point(22, 520);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(22, 8, 22, 8);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.ResetButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.ResetButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.ResetButton.Size = new System.Drawing.Size(119, 39);
            this.ResetButton.TabIndex = 32;
            this.ResetButton.Text = "Reset";
            this.ResetButton.TextColor = System.Drawing.Color.White;
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // DisplayView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(908, 662);
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
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).EndInit();
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
        private CustomRoundButton ResetButton;
        private CustomRoundButton ComicButton;
        private CustomRoundButton InvertButton;
        private CustomRoundButton SepiaButton;
        private CustomRoundButton LomoButton;
        private CustomRoundButton OriginalButton;
        private CustomRoundButton BWButton;
        private System.Windows.Forms.Label ConstrastLabel;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.TrackBar SaturationTrackBar;
        private System.Windows.Forms.Label SaturationLabel;
    }
}