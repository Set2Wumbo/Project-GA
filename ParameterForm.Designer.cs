namespace ProjectGA
{
    partial class ParameterForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCostPerOrder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHoldingCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCrossoverProbability = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOrderProbability = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMutationProbability = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumofPeriods = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPopulationsize = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.DarkGreen;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.button1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1042, 49);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(413, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Determine Parameters";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::ProjectGA.Properties.Resources.delete_32px;
            this.button1.Location = new System.Drawing.Point(997, 4);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 42);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.txtCostPerOrder);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtHoldingCost);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCrossoverProbability);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtOrderProbability);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMutationProbability);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumofPeriods);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPopulationsize);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(101, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(854, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // txtCostPerOrder
            // 
            this.txtCostPerOrder.Location = new System.Drawing.Point(710, 121);
            this.txtCostPerOrder.Name = "txtCostPerOrder";
            this.txtCostPerOrder.Size = new System.Drawing.Size(100, 26);
            this.txtCostPerOrder.TabIndex = 7;
            this.txtCostPerOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(488, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(216, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Set up cost per order:";
            // 
            // txtHoldingCost
            // 
            this.txtHoldingCost.Location = new System.Drawing.Point(710, 84);
            this.txtHoldingCost.Name = "txtHoldingCost";
            this.txtHoldingCost.Size = new System.Drawing.Size(100, 26);
            this.txtHoldingCost.TabIndex = 6;
            this.txtHoldingCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(390, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(314, 19);
            this.label7.TabIndex = 14;
            this.label7.Text = "Holding cost per unit per period:";
            // 
            // txtCrossoverProbability
            // 
            this.txtCrossoverProbability.Location = new System.Drawing.Point(710, 44);
            this.txtCrossoverProbability.Name = "txtCrossoverProbability";
            this.txtCrossoverProbability.Size = new System.Drawing.Size(100, 26);
            this.txtCrossoverProbability.TabIndex = 5;
            this.txtCrossoverProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(477, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(227, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Crossover Probability:";
            // 
            // txtOrderProbability
            // 
            this.txtOrderProbability.Location = new System.Drawing.Point(234, 121);
            this.txtOrderProbability.Name = "txtOrderProbability";
            this.txtOrderProbability.Size = new System.Drawing.Size(100, 26);
            this.txtOrderProbability.TabIndex = 3;
            this.txtOrderProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mutation Probability:";
            // 
            // txtMutationProbability
            // 
            this.txtMutationProbability.Location = new System.Drawing.Point(234, 161);
            this.txtMutationProbability.Name = "txtMutationProbability";
            this.txtMutationProbability.Size = new System.Drawing.Size(100, 26);
            this.txtMutationProbability.TabIndex = 4;
            this.txtMutationProbability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Order Probability:";
            // 
            // txtNumofPeriods
            // 
            this.txtNumofPeriods.Location = new System.Drawing.Point(234, 84);
            this.txtNumofPeriods.Name = "txtNumofPeriods";
            this.txtNumofPeriods.Size = new System.Drawing.Size(100, 26);
            this.txtNumofPeriods.TabIndex = 2;
            this.txtNumofPeriods.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumofPeriods.TextChanged += new System.EventHandler(this.txtNumofPeriods_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Number of Periods:";
            // 
            // txtPopulationsize
            // 
            this.txtPopulationsize.Location = new System.Drawing.Point(234, 44);
            this.txtPopulationsize.Name = "txtPopulationsize";
            this.txtPopulationsize.Size = new System.Drawing.Size(100, 26);
            this.txtPopulationsize.TabIndex = 1;
            this.txtPopulationsize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Population Size:";
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Location = new System.Drawing.Point(134, 336);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(76, 19);
            this.lblPeriod.TabIndex = 17;
            this.lblPeriod.Text = "Period:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "Net Requirements:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(389, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(263, 35);
            this.button2.TabIndex = 19;
            this.button2.Text = "Confirm Settings";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ParameterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 504);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPeriod);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Copperplate Gothic Light", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ParameterForm";
            this.Load += new System.EventHandler(this.ParameterForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCostPerOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtHoldingCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCrossoverProbability;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOrderProbability;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMutationProbability;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumofPeriods;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPopulationsize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}