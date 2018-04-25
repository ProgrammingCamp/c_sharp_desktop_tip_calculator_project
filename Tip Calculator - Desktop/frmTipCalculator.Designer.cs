namespace Tip_Calculator___Desktop
{
    partial class frmTipCalculator
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
            this.lblCost = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblServiceQuality = new System.Windows.Forms.Label();
            this.rdbtnGood = new System.Windows.Forms.RadioButton();
            this.rdbtnVeryGood = new System.Windows.Forms.RadioButton();
            this.rdbtnExcellent = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(26, 32);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(89, 20);
            this.lblCost.TabIndex = 0;
            this.lblCost.Text = "Enter Cost:";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(140, 25);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(339, 26);
            this.txtCost.TabIndex = 1;
            // 
            // lblServiceQuality
            // 
            this.lblServiceQuality.AutoSize = true;
            this.lblServiceQuality.Location = new System.Drawing.Point(30, 85);
            this.lblServiceQuality.Name = "lblServiceQuality";
            this.lblServiceQuality.Size = new System.Drawing.Size(113, 20);
            this.lblServiceQuality.TabIndex = 2;
            this.lblServiceQuality.Text = "Service Quality";
            // 
            // rdbtnGood
            // 
            this.rdbtnGood.AutoSize = true;
            this.rdbtnGood.Location = new System.Drawing.Point(34, 136);
            this.rdbtnGood.Name = "rdbtnGood";
            this.rdbtnGood.Size = new System.Drawing.Size(74, 24);
            this.rdbtnGood.TabIndex = 3;
            this.rdbtnGood.TabStop = true;
            this.rdbtnGood.Text = "Good";
            this.rdbtnGood.UseVisualStyleBackColor = true;
            // 
            // rdbtnVeryGood
            // 
            this.rdbtnVeryGood.AutoSize = true;
            this.rdbtnVeryGood.Location = new System.Drawing.Point(199, 136);
            this.rdbtnVeryGood.Name = "rdbtnVeryGood";
            this.rdbtnVeryGood.Size = new System.Drawing.Size(110, 24);
            this.rdbtnVeryGood.TabIndex = 4;
            this.rdbtnVeryGood.TabStop = true;
            this.rdbtnVeryGood.Text = "Very Good";
            this.rdbtnVeryGood.UseVisualStyleBackColor = true;
            // 
            // rdbtnExcellent
            // 
            this.rdbtnExcellent.AutoSize = true;
            this.rdbtnExcellent.Location = new System.Drawing.Point(381, 136);
            this.rdbtnExcellent.Name = "rdbtnExcellent";
            this.rdbtnExcellent.Size = new System.Drawing.Size(98, 24);
            this.rdbtnExcellent.TabIndex = 5;
            this.rdbtnExcellent.TabStop = true;
            this.rdbtnExcellent.Text = "Excellent";
            this.rdbtnExcellent.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(34, 197);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(473, 56);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.AutoSize = true;
            this.lblTotalCost.Location = new System.Drawing.Point(34, 289);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(89, 20);
            this.lblTotalCost.TabIndex = 7;
            this.lblTotalCost.Text = "[Total Cost]";
            // 
            // frmTipCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 471);
            this.Controls.Add(this.lblTotalCost);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rdbtnExcellent);
            this.Controls.Add(this.rdbtnVeryGood);
            this.Controls.Add(this.rdbtnGood);
            this.Controls.Add(this.lblServiceQuality);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.lblCost);
            this.Name = "frmTipCalculator";
            this.Text = "Welcome - Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label lblServiceQuality;
        private System.Windows.Forms.RadioButton rdbtnGood;
        private System.Windows.Forms.RadioButton rdbtnVeryGood;
        private System.Windows.Forms.RadioButton rdbtnExcellent;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblTotalCost;
    }
}

