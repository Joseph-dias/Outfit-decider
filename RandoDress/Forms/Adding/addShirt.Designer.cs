namespace RandoDress.Forms.Adding
{
    partial class addShirt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addShirt));
            this.picBX = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picInfoLBL = new System.Windows.Forms.Label();
            this.checkBX = new System.Windows.Forms.CheckedListBox();
            this.saveBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBX)).BeginInit();
            this.SuspendLayout();
            // 
            // picBX
            // 
            this.picBX.Image = ((System.Drawing.Image)(resources.GetObject("picBX.Image")));
            this.picBX.Location = new System.Drawing.Point(12, 12);
            this.picBX.Name = "picBX";
            this.picBX.Size = new System.Drawing.Size(387, 414);
            this.picBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBX.TabIndex = 0;
            this.picBX.TabStop = false;
            this.picBX.Click += new System.EventHandler(this.picBX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(500, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add a shirt";
            // 
            // picInfoLBL
            // 
            this.picInfoLBL.AutoSize = true;
            this.picInfoLBL.BackColor = System.Drawing.Color.White;
            this.picInfoLBL.Location = new System.Drawing.Point(23, 28);
            this.picInfoLBL.Name = "picInfoLBL";
            this.picInfoLBL.Size = new System.Drawing.Size(128, 17);
            this.picInfoLBL.TabIndex = 2;
            this.picInfoLBL.Text = "Click to add picture";
            // 
            // checkBX
            // 
            this.checkBX.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.checkBX.CheckOnClick = true;
            this.checkBX.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBX.FormattingEnabled = true;
            this.checkBX.Location = new System.Drawing.Point(474, 130);
            this.checkBX.Name = "checkBX";
            this.checkBX.Size = new System.Drawing.Size(247, 202);
            this.checkBX.TabIndex = 3;
            this.checkBX.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkBX_ItemCheck);
            // 
            // saveBTN
            // 
            this.saveBTN.Font = new System.Drawing.Font("Javanese Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBTN.Location = new System.Drawing.Point(522, 353);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(156, 73);
            this.saveBTN.TabIndex = 4;
            this.saveBTN.Text = "Save";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // addShirt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveBTN);
            this.Controls.Add(this.checkBX);
            this.Controls.Add(this.picInfoLBL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "addShirt";
            this.Text = "Add";
            this.Load += new System.EventHandler(this.addShirt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label picInfoLBL;
        private System.Windows.Forms.CheckedListBox checkBX;
        private System.Windows.Forms.Button saveBTN;
    }
}