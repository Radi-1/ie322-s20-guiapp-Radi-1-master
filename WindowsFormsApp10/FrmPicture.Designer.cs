namespace WindowsFormsApp10
{
    partial class FrmPicture
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
            this.BtnImageFromFile = new System.Windows.Forms.Button();
            this.BtnImageFromResource = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.Pic01 = new System.Windows.Forms.PictureBox();
            this.Pic02 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic01)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic02)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnImageFromFile
            // 
            this.BtnImageFromFile.Location = new System.Drawing.Point(42, 52);
            this.BtnImageFromFile.Name = "BtnImageFromFile";
            this.BtnImageFromFile.Size = new System.Drawing.Size(102, 38);
            this.BtnImageFromFile.TabIndex = 0;
            this.BtnImageFromFile.Text = "Image from file";
            this.BtnImageFromFile.UseVisualStyleBackColor = true;
            this.BtnImageFromFile.Click += new System.EventHandler(this.BtnImageFromFile_Click);
            // 
            // BtnImageFromResource
            // 
            this.BtnImageFromResource.Location = new System.Drawing.Point(42, 114);
            this.BtnImageFromResource.Name = "BtnImageFromResource";
            this.BtnImageFromResource.Size = new System.Drawing.Size(124, 41);
            this.BtnImageFromResource.TabIndex = 1;
            this.BtnImageFromResource.Text = "Image from Resource";
            this.BtnImageFromResource.UseVisualStyleBackColor = true;
            this.BtnImageFromResource.Click += new System.EventHandler(this.BtnImageFromResource_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(741, 393);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(83, 32);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // Pic01
            // 
            this.Pic01.Location = new System.Drawing.Point(202, 114);
            this.Pic01.Name = "Pic01";
            this.Pic01.Size = new System.Drawing.Size(289, 215);
            this.Pic01.TabIndex = 3;
            this.Pic01.TabStop = false;
            // 
            // Pic02
            // 
            this.Pic02.Location = new System.Drawing.Point(528, 114);
            this.Pic02.Name = "Pic02";
            this.Pic02.Size = new System.Drawing.Size(296, 215);
            this.Pic02.TabIndex = 4;
            this.Pic02.TabStop = false;
            // 
            // FrmPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 450);
            this.Controls.Add(this.Pic02);
            this.Controls.Add(this.Pic01);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.BtnImageFromResource);
            this.Controls.Add(this.BtnImageFromFile);
            this.Name = "FrmPicture";
            this.Text = "Picture";
            this.Load += new System.EventHandler(this.FrmPicture_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic01)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic02)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnImageFromFile;
        private System.Windows.Forms.Button BtnImageFromResource;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.PictureBox Pic01;
        private System.Windows.Forms.PictureBox Pic02;
    }
}