namespace TheMediaEditor.Views
{
    partial class CollectionView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ThumbnailsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.separatingLine3 = new System.Windows.Forms.Label();
            this.LoadButton = new TheMediaEditor.CustomRoundButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ThumbnailsFlowPanel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.separatingLine3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.LoadButton, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(529, 467);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ThumbnailsFlowPanel
            // 
            this.ThumbnailsFlowPanel.AutoScroll = true;
            this.ThumbnailsFlowPanel.AutoSize = true;
            this.ThumbnailsFlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThumbnailsFlowPanel.Location = new System.Drawing.Point(3, 3);
            this.ThumbnailsFlowPanel.Name = "ThumbnailsFlowPanel";
            this.ThumbnailsFlowPanel.Size = new System.Drawing.Size(523, 393);
            this.ThumbnailsFlowPanel.TabIndex = 0;
            // 
            // separatingLine3
            // 
            this.separatingLine3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separatingLine3.AutoSize = true;
            this.separatingLine3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.separatingLine3.Location = new System.Drawing.Point(30, 408);
            this.separatingLine3.Margin = new System.Windows.Forms.Padding(30, 0, 30, 0);
            this.separatingLine3.Name = "separatingLine3";
            this.separatingLine3.Size = new System.Drawing.Size(469, 2);
            this.separatingLine3.TabIndex = 1;
            // 
            // LoadButton
            // 
            this.LoadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.LoadButton.BackColor = System.Drawing.Color.Gray;
            this.LoadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoadButton.BorderColor = System.Drawing.Color.DimGray;
            this.LoadButton.ButtonColor = System.Drawing.Color.Black;
            this.LoadButton.FlatAppearance.BorderSize = 0;
            this.LoadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadButton.Location = new System.Drawing.Point(158, 422);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(30, 3, 30, 3);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.OnHoverBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.LoadButton.OnHoverButtonColor = System.Drawing.Color.White;
            this.LoadButton.OnHoverTextColor = System.Drawing.Color.DeepSkyBlue;
            this.LoadButton.Size = new System.Drawing.Size(212, 42);
            this.LoadButton.TabIndex = 9;
            this.LoadButton.Text = "Open...";
            this.LoadButton.TextColor = System.Drawing.Color.White;
            this.LoadButton.UseVisualStyleBackColor = false;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // CollectionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(531, 486);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(200, 300);
            this.Name = "CollectionView";
            this.Text = "CollectionView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel ThumbnailsFlowPanel;
        private System.Windows.Forms.Label separatingLine3;
        private CustomRoundButton LoadButton;
    }
}