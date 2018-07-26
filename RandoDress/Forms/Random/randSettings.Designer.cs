namespace RandoDress.Forms.Random
{
    partial class randSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(randSettings));
            this.checkPNL = new System.Windows.Forms.FlowLayoutPanel();
            this.numLBL = new System.Windows.Forms.Label();
            this.numOUT = new System.Windows.Forms.NumericUpDown();
            this.goBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numOUT)).BeginInit();
            this.SuspendLayout();
            // 
            // checkPNL
            // 
            this.checkPNL.AutoScroll = true;
            this.checkPNL.Dock = System.Windows.Forms.DockStyle.Top;
            this.checkPNL.Location = new System.Drawing.Point(0, 0);
            this.checkPNL.Name = "checkPNL";
            this.checkPNL.Padding = new System.Windows.Forms.Padding(15, 10, 15, 0);
            this.checkPNL.Size = new System.Drawing.Size(651, 56);
            this.checkPNL.TabIndex = 0;
            // 
            // numLBL
            // 
            this.numLBL.AutoSize = true;
            this.numLBL.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLBL.Location = new System.Drawing.Point(33, 86);
            this.numLBL.Name = "numLBL";
            this.numLBL.Size = new System.Drawing.Size(304, 23);
            this.numLBL.TabIndex = 1;
            this.numLBL.Text = "NUMBER OF OUTFITS TO DISPLAY:";
            // 
            // numOUT
            // 
            this.numOUT.Location = new System.Drawing.Point(403, 86);
            this.numOUT.Name = "numOUT";
            this.numOUT.Size = new System.Drawing.Size(63, 22);
            this.numOUT.TabIndex = 2;
            this.numOUT.ValueChanged += new System.EventHandler(this.numOUT_ValueChanged);
            // 
            // goBTN
            // 
            this.goBTN.BackColor = System.Drawing.SystemColors.Window;
            this.goBTN.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goBTN.Location = new System.Drawing.Point(568, 126);
            this.goBTN.Name = "goBTN";
            this.goBTN.Size = new System.Drawing.Size(75, 55);
            this.goBTN.TabIndex = 3;
            this.goBTN.Text = "GO";
            this.goBTN.UseVisualStyleBackColor = false;
            this.goBTN.Click += new System.EventHandler(this.goBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.cancelBTN.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBTN.Location = new System.Drawing.Point(12, 154);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(90, 27);
            this.cancelBTN.TabIndex = 4;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(403, 115);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 21);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "All Shirts";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // randSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBTN;
            this.ClientSize = new System.Drawing.Size(651, 187);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.goBTN);
            this.Controls.Add(this.numOUT);
            this.Controls.Add(this.numLBL);
            this.Controls.Add(this.checkPNL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "randSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.randSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numOUT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel checkPNL;
        private System.Windows.Forms.Label numLBL;
        private System.Windows.Forms.NumericUpDown numOUT;
        private System.Windows.Forms.Button goBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}