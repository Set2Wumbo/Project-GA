namespace ProjectGA
{
    partial class PopulationForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDashBoard = new System.Windows.Forms.Button();
            this.btnConfirmChanges = new System.Windows.Forms.Button();
            this.btnEditChromo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkGreen;
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.btnDashBoard);
            this.panelHeader.Controls.Add(this.btnConfirmChanges);
            this.panelHeader.Controls.Add(this.btnEditChromo);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1062, 49);
            this.panelHeader.TabIndex = 2;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::ProjectGA.Properties.Resources.back_32px;
            this.btnBack.Location = new System.Drawing.Point(969, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 42);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDashBoard
            // 
            this.btnDashBoard.FlatAppearance.BorderSize = 0;
            this.btnDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashBoard.ForeColor = System.Drawing.Color.Transparent;
            this.btnDashBoard.Image = global::ProjectGA.Properties.Resources.report_card_32px;
            this.btnDashBoard.Location = new System.Drawing.Point(157, 3);
            this.btnDashBoard.Name = "btnDashBoard";
            this.btnDashBoard.Size = new System.Drawing.Size(70, 42);
            this.btnDashBoard.TabIndex = 5;
            this.btnDashBoard.UseVisualStyleBackColor = true;
            this.btnDashBoard.Click += new System.EventHandler(this.btnDashBoard_Click);
            // 
            // btnConfirmChanges
            // 
            this.btnConfirmChanges.FlatAppearance.BorderSize = 0;
            this.btnConfirmChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmChanges.ForeColor = System.Drawing.Color.Transparent;
            this.btnConfirmChanges.Image = global::ProjectGA.Properties.Resources.checkmark_32px;
            this.btnConfirmChanges.Location = new System.Drawing.Point(79, 3);
            this.btnConfirmChanges.Name = "btnConfirmChanges";
            this.btnConfirmChanges.Size = new System.Drawing.Size(70, 42);
            this.btnConfirmChanges.TabIndex = 4;
            this.btnConfirmChanges.UseVisualStyleBackColor = true;
            this.btnConfirmChanges.Click += new System.EventHandler(this.btnConfirmChanges_Click);
            // 
            // btnEditChromo
            // 
            this.btnEditChromo.FlatAppearance.BorderSize = 0;
            this.btnEditChromo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditChromo.ForeColor = System.Drawing.Color.Transparent;
            this.btnEditChromo.Image = global::ProjectGA.Properties.Resources.settings_32px;
            this.btnEditChromo.Location = new System.Drawing.Point(3, 4);
            this.btnEditChromo.Name = "btnEditChromo";
            this.btnEditChromo.Size = new System.Drawing.Size(70, 42);
            this.btnEditChromo.TabIndex = 3;
            this.btnEditChromo.UseVisualStyleBackColor = true;
            this.btnEditChromo.Click += new System.EventHandler(this.btnEditChromo_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(450, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Initial Population";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::ProjectGA.Properties.Resources.delete_32px;
            this.button1.Location = new System.Drawing.Point(1017, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PopulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.AutoScrollMinSize = new System.Drawing.Size(1, 1);
            this.ClientSize = new System.Drawing.Size(1062, 505);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PopulationForm";
            this.ShowIcon = false;
            this.Text = "PopulationForm";
            this.Load += new System.EventHandler(this.PopulationForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEditChromo;
        private System.Windows.Forms.Button btnConfirmChanges;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnBack;
    }
}