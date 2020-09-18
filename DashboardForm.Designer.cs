namespace ProjectGA
{
    partial class DashboardForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewRun = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAiInput = new System.Windows.Forms.Button();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEditChromo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkGreen;
            this.panelHeader.Controls.Add(this.btnBack);
            this.panelHeader.Controls.Add(this.btnEditChromo);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1092, 49);
            this.panelHeader.TabIndex = 3;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(442, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dashboard Overview";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.btnNewRun);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Controls.Add(this.btnAiInput);
            this.panel1.Controls.Add(this.btnAnalysis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 496);
            this.panel1.TabIndex = 4;
            // 
            // btnNewRun
            // 
            this.btnNewRun.FlatAppearance.BorderSize = 0;
            this.btnNewRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewRun.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewRun.Image = global::ProjectGA.Properties.Resources.checkmark_32px1;
            this.btnNewRun.Location = new System.Drawing.Point(0, 103);
            this.btnNewRun.Name = "btnNewRun";
            this.btnNewRun.Size = new System.Drawing.Size(149, 67);
            this.btnNewRun.TabIndex = 12;
            this.btnNewRun.Text = "New Run";
            this.btnNewRun.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNewRun.UseVisualStyleBackColor = true;
            this.btnNewRun.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkGreen;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Transparent;
            this.btnHome.Image = global::ProjectGA.Properties.Resources.home_32px;
            this.btnHome.Location = new System.Drawing.Point(0, 31);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(149, 67);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAiInput
            // 
            this.btnAiInput.FlatAppearance.BorderSize = 0;
            this.btnAiInput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAiInput.ForeColor = System.Drawing.Color.Transparent;
            this.btnAiInput.Image = global::ProjectGA.Properties.Resources.eye_32px;
            this.btnAiInput.Location = new System.Drawing.Point(0, 250);
            this.btnAiInput.Name = "btnAiInput";
            this.btnAiInput.Size = new System.Drawing.Size(149, 67);
            this.btnAiInput.TabIndex = 11;
            this.btnAiInput.Text = "A.I. Input";
            this.btnAiInput.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAiInput.UseVisualStyleBackColor = true;
            this.btnAiInput.Click += new System.EventHandler(this.btnAiInput_Click);
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.FlatAppearance.BorderSize = 0;
            this.btnAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalysis.ForeColor = System.Drawing.Color.Transparent;
            this.btnAnalysis.Image = global::ProjectGA.Properties.Resources.idea_32px;
            this.btnAnalysis.Location = new System.Drawing.Point(0, 177);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(149, 67);
            this.btnAnalysis.TabIndex = 10;
            this.btnAnalysis.Text = "Analysis";
            this.btnAnalysis.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnaylsis_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Image = global::ProjectGA.Properties.Resources.back_32px;
            this.btnBack.Location = new System.Drawing.Point(999, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(40, 42);
            this.btnBack.TabIndex = 6;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::ProjectGA.Properties.Resources.delete_32px;
            this.button1.Location = new System.Drawing.Point(1047, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEditChromo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnAiInput;
        private System.Windows.Forms.Button btnNewRun;
    }
}