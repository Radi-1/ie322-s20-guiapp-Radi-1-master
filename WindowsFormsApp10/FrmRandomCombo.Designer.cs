namespace WindowsFormsApp10
{
    partial class FrmRandomCombo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbRandom1 = new System.Windows.Forms.ComboBox();
            this.BtnG1 = new System.Windows.Forms.Button();
            this.RdoL500 = new System.Windows.Forms.RadioButton();
            this.RdoG500 = new System.Windows.Forms.RadioButton();
            this.RdoL50 = new System.Windows.Forms.RadioButton();
            this.BtnG50 = new System.Windows.Forms.RadioButton();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnG2 = new System.Windows.Forms.Button();
            this.BtnReset1 = new System.Windows.Forms.Button();
            this.CmbRandom2 = new System.Windows.Forms.ComboBox();
            this.BtnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnReset);
            this.groupBox1.Controls.Add(this.RdoG500);
            this.groupBox1.Controls.Add(this.RdoL500);
            this.groupBox1.Controls.Add(this.BtnG1);
            this.groupBox1.Controls.Add(this.CmbRandom1);
            this.groupBox1.Location = new System.Drawing.Point(120, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 168);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbRandom2);
            this.groupBox2.Controls.Add(this.BtnReset1);
            this.groupBox2.Controls.Add(this.BtnG2);
            this.groupBox2.Controls.Add(this.BtnG50);
            this.groupBox2.Controls.Add(this.RdoL50);
            this.groupBox2.Location = new System.Drawing.Point(468, 95);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 168);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // CmbRandom1
            // 
            this.CmbRandom1.FormattingEnabled = true;
            this.CmbRandom1.Location = new System.Drawing.Point(6, 36);
            this.CmbRandom1.Name = "CmbRandom1";
            this.CmbRandom1.Size = new System.Drawing.Size(121, 21);
            this.CmbRandom1.TabIndex = 0;
            // 
            // BtnG1
            // 
            this.BtnG1.Location = new System.Drawing.Point(188, 36);
            this.BtnG1.Name = "BtnG1";
            this.BtnG1.Size = new System.Drawing.Size(75, 23);
            this.BtnG1.TabIndex = 1;
            this.BtnG1.Text = "Generate";
            this.BtnG1.UseVisualStyleBackColor = true;
            // 
            // RdoL500
            // 
            this.RdoL500.AutoSize = true;
            this.RdoL500.Location = new System.Drawing.Point(150, 84);
            this.RdoL500.Name = "RdoL500";
            this.RdoL500.Size = new System.Drawing.Size(92, 17);
            this.RdoL500.TabIndex = 2;
            this.RdoL500.TabStop = true;
            this.RdoL500.Text = "Less than 500";
            this.RdoL500.UseVisualStyleBackColor = true;
            // 
            // RdoG500
            // 
            this.RdoG500.AutoSize = true;
            this.RdoG500.Location = new System.Drawing.Point(150, 122);
            this.RdoG500.Name = "RdoG500";
            this.RdoG500.Size = new System.Drawing.Size(108, 17);
            this.RdoG500.TabIndex = 3;
            this.RdoG500.TabStop = true;
            this.RdoG500.Text = "Greater than 500";
            this.RdoG500.UseVisualStyleBackColor = true;
            // 
            // RdoL50
            // 
            this.RdoL50.AutoSize = true;
            this.RdoL50.Location = new System.Drawing.Point(170, 84);
            this.RdoL50.Name = "RdoL50";
            this.RdoL50.Size = new System.Drawing.Size(86, 17);
            this.RdoL50.TabIndex = 0;
            this.RdoL50.TabStop = true;
            this.RdoL50.Text = "Less than 50";
            this.RdoL50.UseVisualStyleBackColor = true;
            // 
            // BtnG50
            // 
            this.BtnG50.AutoSize = true;
            this.BtnG50.Location = new System.Drawing.Point(170, 122);
            this.BtnG50.Name = "BtnG50";
            this.BtnG50.Size = new System.Drawing.Size(102, 17);
            this.BtnG50.TabIndex = 1;
            this.BtnG50.TabStop = true;
            this.BtnG50.Text = "Greater than 50";
            this.BtnG50.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(40, 122);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(75, 23);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // BtnG2
            // 
            this.BtnG2.Location = new System.Drawing.Point(182, 34);
            this.BtnG2.Name = "BtnG2";
            this.BtnG2.Size = new System.Drawing.Size(75, 23);
            this.BtnG2.TabIndex = 2;
            this.BtnG2.Text = "Generate";
            this.BtnG2.UseVisualStyleBackColor = true;
            this.BtnG2.Click += new System.EventHandler(this.BtnG2_Click);
            // 
            // BtnReset1
            // 
            this.BtnReset1.Location = new System.Drawing.Point(66, 122);
            this.BtnReset1.Name = "BtnReset1";
            this.BtnReset1.Size = new System.Drawing.Size(75, 23);
            this.BtnReset1.TabIndex = 3;
            this.BtnReset1.Text = "Reset";
            this.BtnReset1.UseVisualStyleBackColor = true;
            // 
            // CmbRandom2
            // 
            this.CmbRandom2.FormattingEnabled = true;
            this.CmbRandom2.Location = new System.Drawing.Point(20, 36);
            this.CmbRandom2.Name = "CmbRandom2";
            this.CmbRandom2.Size = new System.Drawing.Size(121, 21);
            this.CmbRandom2.TabIndex = 4;
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(468, 355);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(124, 37);
            this.BtnBack.TabIndex = 2;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // FrmRandomCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmRandomCombo";
            this.Text = "FrmRandomCombo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.RadioButton RdoG500;
        private System.Windows.Forms.RadioButton RdoL500;
        private System.Windows.Forms.Button BtnG1;
        private System.Windows.Forms.ComboBox CmbRandom1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox CmbRandom2;
        private System.Windows.Forms.Button BtnReset1;
        private System.Windows.Forms.Button BtnG2;
        private System.Windows.Forms.RadioButton BtnG50;
        private System.Windows.Forms.RadioButton RdoL50;
        private System.Windows.Forms.Button BtnBack;
    }
}