namespace WindowsFormsApp10
{
    partial class FrmCombo
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
            this.BtnShowM1 = new System.Windows.Forms.Button();
            this.BtnShowM2 = new System.Windows.Forms.Button();
            this.BtnIndex = new System.Windows.Forms.Button();
            this.BtnName = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.Btn2nd = new System.Windows.Forms.Button();
            this.BtnBack = new System.Windows.Forms.Button();
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.LblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnShowM1
            // 
            this.BtnShowM1.Location = new System.Drawing.Point(50, 49);
            this.BtnShowM1.Name = "BtnShowM1";
            this.BtnShowM1.Size = new System.Drawing.Size(155, 42);
            this.BtnShowM1.TabIndex = 0;
            this.BtnShowM1.Text = "Show selected method 1";
            this.BtnShowM1.UseVisualStyleBackColor = true;
            this.BtnShowM1.Click += new System.EventHandler(this.BtnShowM1_Click);
            // 
            // BtnShowM2
            // 
            this.BtnShowM2.Location = new System.Drawing.Point(262, 49);
            this.BtnShowM2.Name = "BtnShowM2";
            this.BtnShowM2.Size = new System.Drawing.Size(144, 42);
            this.BtnShowM2.TabIndex = 1;
            this.BtnShowM2.Text = "Show selected method 2";
            this.BtnShowM2.UseVisualStyleBackColor = true;
            // 
            // BtnIndex
            // 
            this.BtnIndex.Location = new System.Drawing.Point(50, 194);
            this.BtnIndex.Name = "BtnIndex";
            this.BtnIndex.Size = new System.Drawing.Size(124, 57);
            this.BtnIndex.TabIndex = 2;
            this.BtnIndex.Text = "Remove by index";
            this.BtnIndex.UseVisualStyleBackColor = true;
            this.BtnIndex.Click += new System.EventHandler(this.BtnIndex_Click);
            // 
            // BtnName
            // 
            this.BtnName.Location = new System.Drawing.Point(222, 194);
            this.BtnName.Name = "BtnName";
            this.BtnName.Size = new System.Drawing.Size(139, 57);
            this.BtnName.TabIndex = 3;
            this.BtnName.Text = "Remove by Name";
            this.BtnName.UseVisualStyleBackColor = true;
            this.BtnName.Click += new System.EventHandler(this.BtnName_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Location = new System.Drawing.Point(480, 49);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(154, 65);
            this.BtnLast.TabIndex = 4;
            this.BtnLast.Text = "Remove last item";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // Btn2nd
            // 
            this.Btn2nd.Location = new System.Drawing.Point(480, 194);
            this.Btn2nd.Name = "Btn2nd";
            this.Btn2nd.Size = new System.Drawing.Size(154, 76);
            this.Btn2nd.TabIndex = 5;
            this.Btn2nd.Text = "Remove 2nd last item";
            this.Btn2nd.UseVisualStyleBackColor = true;
            this.Btn2nd.Click += new System.EventHandler(this.Btn2nd_Click);
            // 
            // BtnBack
            // 
            this.BtnBack.Location = new System.Drawing.Point(609, 333);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(111, 48);
            this.BtnBack.TabIndex = 6;
            this.BtnBack.Text = "Back";
            this.BtnBack.UseVisualStyleBackColor = true;
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(161, 130);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(121, 21);
            this.CmbDays.TabIndex = 7;
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.Location = new System.Drawing.Point(85, 130);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(31, 13);
            this.LblDays.TabIndex = 8;
            this.LblDays.Text = "Days";
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblDays);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnBack);
            this.Controls.Add(this.Btn2nd);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.BtnName);
            this.Controls.Add(this.BtnIndex);
            this.Controls.Add(this.BtnShowM2);
            this.Controls.Add(this.BtnShowM1);
            this.Name = "FrmCombo";
            this.Text = "FrmCombo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowM1;
        private System.Windows.Forms.Button BtnShowM2;
        private System.Windows.Forms.Button BtnIndex;
        private System.Windows.Forms.Button BtnName;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button Btn2nd;
        private System.Windows.Forms.Button BtnBack;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Label LblDays;
    }
}