﻿namespace WindowsFormsApp10
{
    partial class FrmRadio
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
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdoYellow2 = new System.Windows.Forms.RadioButton();
            this.RdoBlue2 = new System.Windows.Forms.RadioButton();
            this.RdoGreen2 = new System.Windows.Forms.RadioButton();
            this.RdoRed2 = new System.Windows.Forms.RadioButton();
            this.RdoRed = new System.Windows.Forms.RadioButton();
            this.RdoGreen = new System.Windows.Forms.RadioButton();
            this.RdoBlue = new System.Windows.Forms.RadioButton();
            this.RdoYellow = new System.Windows.Forms.RadioButton();
            this.BtnReset = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(253, 313);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(87, 25);
            this.BtnBack.TabIndex = 0;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdoYellow2);
            this.groupBox1.Controls.Add(this.RdoBlue2);
            this.groupBox1.Controls.Add(this.RdoGreen2);
            this.groupBox1.Controls.Add(this.RdoRed2);
            this.groupBox1.Location = new System.Drawing.Point(195, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grouped Radio Buttons";
            // 
            // RdoYellow2
            // 
            this.RdoYellow2.AutoSize = true;
            this.RdoYellow2.Location = new System.Drawing.Point(58, 138);
            this.RdoYellow2.Name = "RdoYellow2";
            this.RdoYellow2.Size = new System.Drawing.Size(55, 17);
            this.RdoYellow2.TabIndex = 3;
            this.RdoYellow2.TabStop = true;
            this.RdoYellow2.Text = "Yellow";
            this.RdoYellow2.UseVisualStyleBackColor = true;
            // 
            // RdoBlue2
            // 
            this.RdoBlue2.AutoSize = true;
            this.RdoBlue2.Location = new System.Drawing.Point(58, 104);
            this.RdoBlue2.Name = "RdoBlue2";
            this.RdoBlue2.Size = new System.Drawing.Size(45, 17);
            this.RdoBlue2.TabIndex = 2;
            this.RdoBlue2.TabStop = true;
            this.RdoBlue2.Text = "Blue";
            this.RdoBlue2.UseVisualStyleBackColor = true;
            // 
            // RdoGreen2
            // 
            this.RdoGreen2.AutoSize = true;
            this.RdoGreen2.Location = new System.Drawing.Point(58, 64);
            this.RdoGreen2.Name = "RdoGreen2";
            this.RdoGreen2.Size = new System.Drawing.Size(54, 17);
            this.RdoGreen2.TabIndex = 1;
            this.RdoGreen2.TabStop = true;
            this.RdoGreen2.Text = "Green";
            this.RdoGreen2.UseVisualStyleBackColor = true;
            // 
            // RdoRed2
            // 
            this.RdoRed2.AutoSize = true;
            this.RdoRed2.Location = new System.Drawing.Point(58, 31);
            this.RdoRed2.Name = "RdoRed2";
            this.RdoRed2.Size = new System.Drawing.Size(44, 17);
            this.RdoRed2.TabIndex = 0;
            this.RdoRed2.TabStop = true;
            this.RdoRed2.Text = "Red";
            this.RdoRed2.UseVisualStyleBackColor = true;
            // 
            // RdoRed
            // 
            this.RdoRed.AutoSize = true;
            this.RdoRed.Location = new System.Drawing.Point(62, 113);
            this.RdoRed.Name = "RdoRed";
            this.RdoRed.Size = new System.Drawing.Size(44, 17);
            this.RdoRed.TabIndex = 2;
            this.RdoRed.TabStop = true;
            this.RdoRed.Text = "Red";
            this.RdoRed.UseVisualStyleBackColor = true;
            this.RdoRed.CheckedChanged += new System.EventHandler(this.RdoRed_CheckedChanged);
            // 
            // RdoGreen
            // 
            this.RdoGreen.AutoSize = true;
            this.RdoGreen.Location = new System.Drawing.Point(62, 146);
            this.RdoGreen.Name = "RdoGreen";
            this.RdoGreen.Size = new System.Drawing.Size(54, 17);
            this.RdoGreen.TabIndex = 3;
            this.RdoGreen.TabStop = true;
            this.RdoGreen.Text = "Green";
            this.RdoGreen.UseVisualStyleBackColor = true;
            this.RdoGreen.CheckedChanged += new System.EventHandler(this.RdoGreen_CheckedChanged);
            // 
            // RdoBlue
            // 
            this.RdoBlue.AutoSize = true;
            this.RdoBlue.Location = new System.Drawing.Point(62, 186);
            this.RdoBlue.Name = "RdoBlue";
            this.RdoBlue.Size = new System.Drawing.Size(45, 17);
            this.RdoBlue.TabIndex = 4;
            this.RdoBlue.TabStop = true;
            this.RdoBlue.Text = "Blue";
            this.RdoBlue.UseVisualStyleBackColor = true;
            this.RdoBlue.CheckedChanged += new System.EventHandler(this.RdoBlue_CheckedChanged);
            // 
            // RdoYellow
            // 
            this.RdoYellow.AutoSize = true;
            this.RdoYellow.Location = new System.Drawing.Point(62, 220);
            this.RdoYellow.Name = "RdoYellow";
            this.RdoYellow.Size = new System.Drawing.Size(55, 17);
            this.RdoYellow.TabIndex = 5;
            this.RdoYellow.TabStop = true;
            this.RdoYellow.Text = "Yellow";
            this.RdoYellow.UseVisualStyleBackColor = true;
            this.RdoYellow.CheckedChanged += new System.EventHandler(this.RdoYellow_CheckedChanged);
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(167, 25);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(103, 32);
            this.BtnReset.TabIndex = 6;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FrmRadio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 393);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.RdoYellow);
            this.Controls.Add(this.RdoBlue);
            this.Controls.Add(this.RdoGreen);
            this.Controls.Add(this.RdoRed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnBack);
            this.Name = "FrmRadio";
            this.Text = "Radio Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdoYellow2;
        private System.Windows.Forms.RadioButton RdoBlue2;
        private System.Windows.Forms.RadioButton RdoGreen2;
        private System.Windows.Forms.RadioButton RdoRed2;
        private System.Windows.Forms.RadioButton RdoRed;
        private System.Windows.Forms.RadioButton RdoGreen;
        private System.Windows.Forms.RadioButton RdoBlue;
        private System.Windows.Forms.RadioButton RdoYellow;
        private System.Windows.Forms.Button BtnReset;
    }
}