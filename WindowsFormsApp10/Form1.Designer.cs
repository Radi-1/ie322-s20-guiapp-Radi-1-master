namespace WindowsFormsApp10
{
    partial class FrmMain
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
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblPassword = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnRadio = new System.Windows.Forms.Button();
            this.BtnCheckBox = new System.Windows.Forms.Button();
            this.BtnCombo = new System.Windows.Forms.Button();
            this.BtnPictureBox = new System.Windows.Forms.Button();
            this.BtnProgress = new System.Windows.Forms.Button();
            this.BtnRandomCombo = new System.Windows.Forms.Button();
            this.BtnPictureBox2 = new System.Windows.Forms.Button();
            this.BtnSelfieApp = new System.Windows.Forms.Button();
            this.BtnDraw = new System.Windows.Forms.Button();
            this.BtnGroupieApp = new System.Windows.Forms.Button();
            this.BtnTalk = new System.Windows.Forms.Button();
            this.BtnTimer = new System.Windows.Forms.Button();
            this.BtnRandom = new System.Windows.Forms.Button();
            this.BtnManufacturingCell = new System.Windows.Forms.Button();
            this.BtnArduino = new System.Windows.Forms.Button();
            this.BtnRoboticCell = new System.Windows.Forms.Button();
            this.BtnJohari = new System.Windows.Forms.Button();
            this.BtnAbcAnalysis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnExit
            // 
            this.BtnExit.Location = new System.Drawing.Point(112, 208);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(75, 35);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BTNexit_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(12, 208);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(94, 35);
            this.BtnLogin.TabIndex = 1;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(147, 24);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(100, 20);
            this.TxtUser.TabIndex = 2;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(147, 80);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(100, 20);
            this.TxtPassword.TabIndex = 3;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Location = new System.Drawing.Point(16, 31);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(55, 13);
            this.LblUser.TabIndex = 4;
            this.LblUser.Text = "Username";
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Location = new System.Drawing.Point(16, 87);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(53, 13);
            this.LblPassword.TabIndex = 5;
            this.LblPassword.Text = "Password";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtUser);
            this.groupBox1.Controls.Add(this.LblPassword);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.LblUser);
            this.groupBox1.Location = new System.Drawing.Point(12, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 139);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // BtnRadio
            // 
            this.BtnRadio.Location = new System.Drawing.Point(307, 56);
            this.BtnRadio.Name = "BtnRadio";
            this.BtnRadio.Size = new System.Drawing.Size(105, 30);
            this.BtnRadio.TabIndex = 7;
            this.BtnRadio.Text = "Radio";
            this.BtnRadio.UseVisualStyleBackColor = true;
            this.BtnRadio.Click += new System.EventHandler(this.BtnRadio_Click);
            // 
            // BtnCheckBox
            // 
            this.BtnCheckBox.Location = new System.Drawing.Point(307, 92);
            this.BtnCheckBox.Name = "BtnCheckBox";
            this.BtnCheckBox.Size = new System.Drawing.Size(105, 28);
            this.BtnCheckBox.TabIndex = 8;
            this.BtnCheckBox.Text = "CheckBox";
            this.BtnCheckBox.UseVisualStyleBackColor = true;
            this.BtnCheckBox.Click += new System.EventHandler(this.BtnCheckBox_Click);
            // 
            // BtnCombo
            // 
            this.BtnCombo.Location = new System.Drawing.Point(418, 57);
            this.BtnCombo.Name = "BtnCombo";
            this.BtnCombo.Size = new System.Drawing.Size(119, 30);
            this.BtnCombo.TabIndex = 9;
            this.BtnCombo.Text = "Combo";
            this.BtnCombo.UseVisualStyleBackColor = true;
            this.BtnCombo.Click += new System.EventHandler(this.BtnCombo_Click);
            // 
            // BtnPictureBox
            // 
            this.BtnPictureBox.Location = new System.Drawing.Point(543, 57);
            this.BtnPictureBox.Name = "BtnPictureBox";
            this.BtnPictureBox.Size = new System.Drawing.Size(120, 30);
            this.BtnPictureBox.TabIndex = 10;
            this.BtnPictureBox.Text = "PictureBox";
            this.BtnPictureBox.UseVisualStyleBackColor = true;
            this.BtnPictureBox.Click += new System.EventHandler(this.BtnPictureBox_Click);
            // 
            // BtnProgress
            // 
            this.BtnProgress.Location = new System.Drawing.Point(790, 56);
            this.BtnProgress.Name = "BtnProgress";
            this.BtnProgress.Size = new System.Drawing.Size(115, 31);
            this.BtnProgress.TabIndex = 11;
            this.BtnProgress.Text = "Progress";
            this.BtnProgress.UseVisualStyleBackColor = true;
            // 
            // BtnRandomCombo
            // 
            this.BtnRandomCombo.Location = new System.Drawing.Point(790, 161);
            this.BtnRandomCombo.Name = "BtnRandomCombo";
            this.BtnRandomCombo.Size = new System.Drawing.Size(115, 27);
            this.BtnRandomCombo.TabIndex = 12;
            this.BtnRandomCombo.Text = "RandomCombo";
            this.BtnRandomCombo.UseVisualStyleBackColor = true;
            this.BtnRandomCombo.Click += new System.EventHandler(this.BtnRandomCombo_Click);
            // 
            // BtnPictureBox2
            // 
            this.BtnPictureBox2.Location = new System.Drawing.Point(543, 91);
            this.BtnPictureBox2.Name = "BtnPictureBox2";
            this.BtnPictureBox2.Size = new System.Drawing.Size(120, 29);
            this.BtnPictureBox2.TabIndex = 13;
            this.BtnPictureBox2.Text = "PictureBox2";
            this.BtnPictureBox2.UseVisualStyleBackColor = true;
            // 
            // BtnSelfieApp
            // 
            this.BtnSelfieApp.Location = new System.Drawing.Point(669, 57);
            this.BtnSelfieApp.Name = "BtnSelfieApp";
            this.BtnSelfieApp.Size = new System.Drawing.Size(115, 30);
            this.BtnSelfieApp.TabIndex = 14;
            this.BtnSelfieApp.Text = "SelfieApp";
            this.BtnSelfieApp.UseVisualStyleBackColor = true;
            // 
            // BtnDraw
            // 
            this.BtnDraw.Location = new System.Drawing.Point(911, 92);
            this.BtnDraw.Name = "BtnDraw";
            this.BtnDraw.Size = new System.Drawing.Size(118, 28);
            this.BtnDraw.TabIndex = 15;
            this.BtnDraw.Text = "Draw";
            this.BtnDraw.UseVisualStyleBackColor = true;
            // 
            // BtnGroupieApp
            // 
            this.BtnGroupieApp.Location = new System.Drawing.Point(669, 91);
            this.BtnGroupieApp.Name = "BtnGroupieApp";
            this.BtnGroupieApp.Size = new System.Drawing.Size(115, 29);
            this.BtnGroupieApp.TabIndex = 16;
            this.BtnGroupieApp.Text = "Groupie App";
            this.BtnGroupieApp.UseVisualStyleBackColor = true;
            // 
            // BtnTalk
            // 
            this.BtnTalk.Location = new System.Drawing.Point(911, 126);
            this.BtnTalk.Name = "BtnTalk";
            this.BtnTalk.Size = new System.Drawing.Size(118, 29);
            this.BtnTalk.TabIndex = 17;
            this.BtnTalk.Text = "Talk";
            this.BtnTalk.UseVisualStyleBackColor = true;
            // 
            // BtnTimer
            // 
            this.BtnTimer.Location = new System.Drawing.Point(790, 91);
            this.BtnTimer.Name = "BtnTimer";
            this.BtnTimer.Size = new System.Drawing.Size(115, 29);
            this.BtnTimer.TabIndex = 18;
            this.BtnTimer.Text = "Timer";
            this.BtnTimer.UseVisualStyleBackColor = true;
            // 
            // BtnRandom
            // 
            this.BtnRandom.Location = new System.Drawing.Point(790, 126);
            this.BtnRandom.Name = "BtnRandom";
            this.BtnRandom.Size = new System.Drawing.Size(115, 29);
            this.BtnRandom.TabIndex = 19;
            this.BtnRandom.Text = "Random";
            this.BtnRandom.UseVisualStyleBackColor = true;
            this.BtnRandom.Click += new System.EventHandler(this.BtnRandom_Click);
            // 
            // BtnManufacturingCell
            // 
            this.BtnManufacturingCell.Location = new System.Drawing.Point(388, 267);
            this.BtnManufacturingCell.Name = "BtnManufacturingCell";
            this.BtnManufacturingCell.Size = new System.Drawing.Size(214, 57);
            this.BtnManufacturingCell.TabIndex = 20;
            this.BtnManufacturingCell.Text = "Manufacturing Cell";
            this.BtnManufacturingCell.UseVisualStyleBackColor = true;
            // 
            // BtnArduino
            // 
            this.BtnArduino.Location = new System.Drawing.Point(388, 384);
            this.BtnArduino.Name = "BtnArduino";
            this.BtnArduino.Size = new System.Drawing.Size(214, 52);
            this.BtnArduino.TabIndex = 21;
            this.BtnArduino.Text = "Arduino";
            this.BtnArduino.UseVisualStyleBackColor = true;
            // 
            // BtnRoboticCell
            // 
            this.BtnRoboticCell.Location = new System.Drawing.Point(388, 330);
            this.BtnRoboticCell.Name = "BtnRoboticCell";
            this.BtnRoboticCell.Size = new System.Drawing.Size(214, 48);
            this.BtnRoboticCell.TabIndex = 22;
            this.BtnRoboticCell.Text = "Robotic Cell";
            this.BtnRoboticCell.UseVisualStyleBackColor = true;
            // 
            // BtnJohari
            // 
            this.BtnJohari.Location = new System.Drawing.Point(608, 267);
            this.BtnJohari.Name = "BtnJohari";
            this.BtnJohari.Size = new System.Drawing.Size(215, 57);
            this.BtnJohari.TabIndex = 23;
            this.BtnJohari.Text = "Johari";
            this.BtnJohari.UseVisualStyleBackColor = true;
            // 
            // BtnAbcAnalysis
            // 
            this.BtnAbcAnalysis.Location = new System.Drawing.Point(608, 330);
            this.BtnAbcAnalysis.Name = "BtnAbcAnalysis";
            this.BtnAbcAnalysis.Size = new System.Drawing.Size(215, 48);
            this.BtnAbcAnalysis.TabIndex = 24;
            this.BtnAbcAnalysis.Text = "ABC Analysis";
            this.BtnAbcAnalysis.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 455);
            this.Controls.Add(this.BtnAbcAnalysis);
            this.Controls.Add(this.BtnJohari);
            this.Controls.Add(this.BtnRoboticCell);
            this.Controls.Add(this.BtnArduino);
            this.Controls.Add(this.BtnManufacturingCell);
            this.Controls.Add(this.BtnRandom);
            this.Controls.Add(this.BtnTimer);
            this.Controls.Add(this.BtnTalk);
            this.Controls.Add(this.BtnGroupieApp);
            this.Controls.Add(this.BtnDraw);
            this.Controls.Add(this.BtnSelfieApp);
            this.Controls.Add(this.BtnPictureBox2);
            this.Controls.Add(this.BtnRandomCombo);
            this.Controls.Add(this.BtnProgress);
            this.Controls.Add(this.BtnPictureBox);
            this.Controls.Add(this.BtnCombo);
            this.Controls.Add(this.BtnCheckBox);
            this.Controls.Add(this.BtnRadio);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.BtnExit);
            this.Name = "FrmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRadio;
        private System.Windows.Forms.Button BtnCheckBox;
        private System.Windows.Forms.Button BtnCombo;
        private System.Windows.Forms.Button BtnPictureBox;
        private System.Windows.Forms.Button BtnProgress;
        private System.Windows.Forms.Button BtnRandomCombo;
        private System.Windows.Forms.Button BtnPictureBox2;
        private System.Windows.Forms.Button BtnSelfieApp;
        private System.Windows.Forms.Button BtnDraw;
        private System.Windows.Forms.Button BtnGroupieApp;
        private System.Windows.Forms.Button BtnTalk;
        private System.Windows.Forms.Button BtnTimer;
        private System.Windows.Forms.Button BtnRandom;
        private System.Windows.Forms.Button BtnManufacturingCell;
        private System.Windows.Forms.Button BtnArduino;
        private System.Windows.Forms.Button BtnRoboticCell;
        private System.Windows.Forms.Button BtnJohari;
        private System.Windows.Forms.Button BtnAbcAnalysis;
    }
}

