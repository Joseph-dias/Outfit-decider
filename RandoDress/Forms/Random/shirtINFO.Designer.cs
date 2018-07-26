namespace RandoDress.Forms.Random
{
    partial class shirtINFO
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.typeTXT = new System.Windows.Forms.Label();
            this.availableTXT = new System.Windows.Forms.Label();
            this.usedTXT = new System.Windows.Forms.Label();
            this.usedBTN = new System.Windows.Forms.Button();
            this.mAvailableBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.weekNUM = new System.Windows.Forms.NumericUpDown();
            this.weeksLBL = new System.Windows.Forms.Label();
            this.weeksPNL = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekNUM)).BeginInit();
            this.weeksPNL.SuspendLayout();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(30, 35);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(346, 375);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 0;
            this.pic.TabStop = false;
            // 
            // typeTXT
            // 
            this.typeTXT.AutoSize = true;
            this.typeTXT.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeTXT.Location = new System.Drawing.Point(495, 35);
            this.typeTXT.Name = "typeTXT";
            this.typeTXT.Size = new System.Drawing.Size(170, 46);
            this.typeTXT.TabIndex = 1;
            this.typeTXT.Text = "MY TYPE";
            this.typeTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // availableTXT
            // 
            this.availableTXT.AutoSize = true;
            this.availableTXT.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableTXT.ForeColor = System.Drawing.Color.LightGreen;
            this.availableTXT.Location = new System.Drawing.Point(462, 163);
            this.availableTXT.Name = "availableTXT";
            this.availableTXT.Size = new System.Drawing.Size(250, 56);
            this.availableTXT.TabIndex = 2;
            this.availableTXT.Text = "AVAILABLE";
            this.availableTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usedTXT
            // 
            this.usedTXT.AutoSize = true;
            this.usedTXT.Font = new System.Drawing.Font("MV Boli", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usedTXT.ForeColor = System.Drawing.Color.Crimson;
            this.usedTXT.Location = new System.Drawing.Point(517, 163);
            this.usedTXT.Name = "usedTXT";
            this.usedTXT.Size = new System.Drawing.Size(134, 56);
            this.usedTXT.TabIndex = 3;
            this.usedTXT.Text = "USED";
            this.usedTXT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usedBTN
            // 
            this.usedBTN.BackColor = System.Drawing.Color.Crimson;
            this.usedBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usedBTN.ForeColor = System.Drawing.Color.GreenYellow;
            this.usedBTN.Location = new System.Drawing.Point(537, 360);
            this.usedBTN.Name = "usedBTN";
            this.usedBTN.Size = new System.Drawing.Size(114, 50);
            this.usedBTN.TabIndex = 4;
            this.usedBTN.Text = "USE";
            this.usedBTN.UseVisualStyleBackColor = false;
            this.usedBTN.Click += new System.EventHandler(this.usedBTN_Click);
            // 
            // mAvailableBTN
            // 
            this.mAvailableBTN.BackColor = System.Drawing.Color.LightGreen;
            this.mAvailableBTN.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mAvailableBTN.ForeColor = System.Drawing.Color.OrangeRed;
            this.mAvailableBTN.Location = new System.Drawing.Point(472, 360);
            this.mAvailableBTN.Name = "mAvailableBTN";
            this.mAvailableBTN.Size = new System.Drawing.Size(254, 50);
            this.mAvailableBTN.TabIndex = 5;
            this.mAvailableBTN.Text = "MAKE AVAILABLE";
            this.mAvailableBTN.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // weekNUM
            // 
            this.weekNUM.Location = new System.Drawing.Point(161, 42);
            this.weekNUM.Name = "weekNUM";
            this.weekNUM.Size = new System.Drawing.Size(75, 22);
            this.weekNUM.TabIndex = 8;
            // 
            // weeksLBL
            // 
            this.weeksLBL.AutoSize = true;
            this.weeksLBL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.weeksLBL.Location = new System.Drawing.Point(26, 42);
            this.weeksLBL.Name = "weeksLBL";
            this.weeksLBL.Size = new System.Drawing.Size(129, 17);
            this.weeksLBL.TabIndex = 9;
            this.weeksLBL.Text = "Number of Weeks: ";
            // 
            // weeksPNL
            // 
            this.weeksPNL.BackColor = System.Drawing.SystemColors.GrayText;
            this.weeksPNL.Controls.Add(this.weeksLBL);
            this.weeksPNL.Controls.Add(this.button2);
            this.weeksPNL.Controls.Add(this.weekNUM);
            this.weeksPNL.Controls.Add(this.button1);
            this.weeksPNL.Location = new System.Drawing.Point(460, 126);
            this.weeksPNL.Name = "weeksPNL";
            this.weeksPNL.Size = new System.Drawing.Size(266, 135);
            this.weeksPNL.TabIndex = 10;
            this.weeksPNL.Visible = false;
            // 
            // shirtINFO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weeksPNL);
            this.Controls.Add(this.mAvailableBTN);
            this.Controls.Add(this.usedBTN);
            this.Controls.Add(this.usedTXT);
            this.Controls.Add(this.availableTXT);
            this.Controls.Add(this.typeTXT);
            this.Controls.Add(this.pic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "shirtINFO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "shirtINFO";
            this.Load += new System.EventHandler(this.shirtINFO_Load);
            this.MouseLeave += new System.EventHandler(this.shirtINFO_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekNUM)).EndInit();
            this.weeksPNL.ResumeLayout(false);
            this.weeksPNL.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Label typeTXT;
        private System.Windows.Forms.Label availableTXT;
        private System.Windows.Forms.Label usedTXT;
        private System.Windows.Forms.Button usedBTN;
        private System.Windows.Forms.Button mAvailableBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown weekNUM;
        private System.Windows.Forms.Label weeksLBL;
        private System.Windows.Forms.Panel weeksPNL;
    }
}