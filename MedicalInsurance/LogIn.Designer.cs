namespace MedicalInsurance.UI
{
    partial class LogIn
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtUserName = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.BtnLogIn = new System.Windows.Forms.Button();
            this.RBtnpharmacy = new System.Windows.Forms.RadioButton();
            this.RBtnDoctor = new System.Windows.Forms.RadioButton();
            this.RBtnInsurance = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 113);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربری:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 175);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "رمز عبور:";
            // 
            // TxtUserName
            // 
            this.TxtUserName.Location = new System.Drawing.Point(147, 113);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.Size = new System.Drawing.Size(173, 27);
            this.TxtUserName.TabIndex = 1;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(147, 175);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(173, 27);
            this.TxtPassword.TabIndex = 1;
            // 
            // BtnLogIn
            // 
            this.BtnLogIn.Location = new System.Drawing.Point(147, 244);
            this.BtnLogIn.Name = "BtnLogIn";
            this.BtnLogIn.Size = new System.Drawing.Size(173, 29);
            this.BtnLogIn.TabIndex = 2;
            this.BtnLogIn.Text = "ورود";
            this.BtnLogIn.UseVisualStyleBackColor = true;
            this.BtnLogIn.Click += new System.EventHandler(this.BtnLogIn_Click);
            // 
            // RBtnpharmacy
            // 
            this.RBtnpharmacy.AutoSize = true;
            this.RBtnpharmacy.Location = new System.Drawing.Point(40, 26);
            this.RBtnpharmacy.Name = "RBtnpharmacy";
            this.RBtnpharmacy.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnpharmacy.Size = new System.Drawing.Size(81, 24);
            this.RBtnpharmacy.TabIndex = 3;
            this.RBtnpharmacy.TabStop = true;
            this.RBtnpharmacy.Text = "داروخانه";
            this.RBtnpharmacy.UseVisualStyleBackColor = true;
            // 
            // RBtnDoctor
            // 
            this.RBtnDoctor.AutoSize = true;
            this.RBtnDoctor.Location = new System.Drawing.Point(196, 26);
            this.RBtnDoctor.Name = "RBtnDoctor";
            this.RBtnDoctor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnDoctor.Size = new System.Drawing.Size(67, 24);
            this.RBtnDoctor.TabIndex = 3;
            this.RBtnDoctor.TabStop = true;
            this.RBtnDoctor.Text = "پزشک";
            this.RBtnDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBtnDoctor.UseVisualStyleBackColor = true;
            // 
            // RBtnInsurance
            // 
            this.RBtnInsurance.AutoSize = true;
            this.RBtnInsurance.Location = new System.Drawing.Point(339, 26);
            this.RBtnInsurance.Name = "RBtnInsurance";
            this.RBtnInsurance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RBtnInsurance.Size = new System.Drawing.Size(57, 24);
            this.RBtnInsurance.TabIndex = 3;
            this.RBtnInsurance.TabStop = true;
            this.RBtnInsurance.Text = "بیمه";
            this.RBtnInsurance.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnLogIn);
            this.groupBox1.Controls.Add(this.RBtnInsurance);
            this.groupBox1.Controls.Add(this.TxtPassword);
            this.groupBox1.Controls.Add(this.RBtnDoctor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RBtnpharmacy);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtUserName);
            this.groupBox1.Location = new System.Drawing.Point(195, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 368);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "LogIn";
            this.Text = "LogIn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TxtUserName;
        private TextBox TxtPassword;
        private Button BtnLogIn;
        private RadioButton RBtnpharmacy;
        private RadioButton RBtnDoctor;
        private RadioButton RBtnInsurance;
        private GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}