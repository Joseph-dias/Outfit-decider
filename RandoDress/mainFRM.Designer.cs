namespace RandoDress
{
    partial class mainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainScreen));
            this.whitePlus = new System.Windows.Forms.PictureBox();
            this.hoverPlus = new System.Windows.Forms.PictureBox();
            this.infinityPICHOV = new System.Windows.Forms.PictureBox();
            this.infinityPIC = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.whitePlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoverPlus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinityPICHOV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinityPIC)).BeginInit();
            this.SuspendLayout();
            // 
            // whitePlus
            // 
            this.whitePlus.Image = ((System.Drawing.Image)(resources.GetObject("whitePlus.Image")));
            this.whitePlus.Location = new System.Drawing.Point(345, -13);
            this.whitePlus.Name = "whitePlus";
            this.whitePlus.Size = new System.Drawing.Size(241, 302);
            this.whitePlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.whitePlus.TabIndex = 0;
            this.whitePlus.TabStop = false;
            this.whitePlus.MouseEnter += new System.EventHandler(this.whitePlus_MouseEnter);
            // 
            // hoverPlus
            // 
            this.hoverPlus.Image = ((System.Drawing.Image)(resources.GetObject("hoverPlus.Image")));
            this.hoverPlus.Location = new System.Drawing.Point(345, -13);
            this.hoverPlus.Name = "hoverPlus";
            this.hoverPlus.Size = new System.Drawing.Size(241, 302);
            this.hoverPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.hoverPlus.TabIndex = 1;
            this.hoverPlus.TabStop = false;
            this.hoverPlus.Visible = false;
            this.hoverPlus.Click += new System.EventHandler(this.hoverPlus_Click);
            this.hoverPlus.MouseEnter += new System.EventHandler(this.hoverPlus_MouseEnter);
            this.hoverPlus.MouseLeave += new System.EventHandler(this.hoverPlus_MouseLeave);
            // 
            // infinityPICHOV
            // 
            this.infinityPICHOV.Image = ((System.Drawing.Image)(resources.GetObject("infinityPICHOV.Image")));
            this.infinityPICHOV.Location = new System.Drawing.Point(32, -13);
            this.infinityPICHOV.Name = "infinityPICHOV";
            this.infinityPICHOV.Size = new System.Drawing.Size(241, 302);
            this.infinityPICHOV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.infinityPICHOV.TabIndex = 2;
            this.infinityPICHOV.TabStop = false;
            this.infinityPICHOV.Visible = false;
            this.infinityPICHOV.Click += new System.EventHandler(this.infinityPICHOV_Click);
            this.infinityPICHOV.MouseLeave += new System.EventHandler(this.infinityPICHOV_MouseLeave);
            // 
            // infinityPIC
            // 
            this.infinityPIC.Image = ((System.Drawing.Image)(resources.GetObject("infinityPIC.Image")));
            this.infinityPIC.Location = new System.Drawing.Point(32, -13);
            this.infinityPIC.Name = "infinityPIC";
            this.infinityPIC.Size = new System.Drawing.Size(241, 302);
            this.infinityPIC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.infinityPIC.TabIndex = 3;
            this.infinityPIC.TabStop = false;
            this.infinityPIC.MouseEnter += new System.EventHandler(this.infinityPIC_MouseEnter);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(698, 374);
            this.Controls.Add(this.infinityPICHOV);
            this.Controls.Add(this.hoverPlus);
            this.Controls.Add(this.whitePlus);
            this.Controls.Add(this.infinityPIC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainScreen";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.whitePlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoverPlus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinityPICHOV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infinityPIC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox whitePlus;
        private System.Windows.Forms.PictureBox hoverPlus;
        private System.Windows.Forms.PictureBox infinityPICHOV;
        private System.Windows.Forms.PictureBox infinityPIC;
    }
}

