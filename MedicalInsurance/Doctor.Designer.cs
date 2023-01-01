namespace MedicalInsurance.UI
{
    partial class Doctor
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnPrescription = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ComboInsuranceType = new System.Windows.Forms.ComboBox();
            this.ComboGender = new System.Windows.Forms.ComboBox();
            this.TxtFamily = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPrescriptionDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnInformation = new System.Windows.Forms.Button();
            this.TxtNationalCode = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(854, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 416);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.BtnInformation);
            this.groupBox2.Controls.Add(this.TxtNationalCode);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(12, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(837, 416);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnPrescription);
            this.groupBox4.Location = new System.Drawing.Point(18, 279);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(819, 119);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // BtnPrescription
            // 
            this.BtnPrescription.Location = new System.Drawing.Point(6, 26);
            this.BtnPrescription.Name = "BtnPrescription";
            this.BtnPrescription.Size = new System.Drawing.Size(782, 29);
            this.BtnPrescription.TabIndex = 6;
            this.BtnPrescription.Text = "نوشتن نسخه";
            this.BtnPrescription.UseVisualStyleBackColor = true;
            this.BtnPrescription.Click += new System.EventHandler(this.BtnPrescription_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnSave);
            this.groupBox3.Controls.Add(this.ComboInsuranceType);
            this.groupBox3.Controls.Add(this.ComboGender);
            this.groupBox3.Controls.Add(this.TxtFamily);
            this.groupBox3.Controls.Add(this.TxtName);
            this.groupBox3.Controls.Add(this.TxtPrescriptionDate);
            this.groupBox3.Controls.Add(this.TxtBirthDate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 205);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(6, 160);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(94, 29);
            this.BtnSave.TabIndex = 3;
            this.BtnSave.Text = "تایید";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ComboInsuranceType
            // 
            this.ComboInsuranceType.FormattingEnabled = true;
            this.ComboInsuranceType.Items.AddRange(new object[] {
            "زن",
            "مرد"});
            this.ComboInsuranceType.Location = new System.Drawing.Point(213, 121);
            this.ComboInsuranceType.Name = "ComboInsuranceType";
            this.ComboInsuranceType.Size = new System.Drawing.Size(125, 28);
            this.ComboInsuranceType.TabIndex = 2;
            // 
            // ComboGender
            // 
            this.ComboGender.FormattingEnabled = true;
            this.ComboGender.Items.AddRange(new object[] {
            "زن",
            "مرد"});
            this.ComboGender.Location = new System.Drawing.Point(213, 71);
            this.ComboGender.Name = "ComboGender";
            this.ComboGender.Size = new System.Drawing.Size(125, 28);
            this.ComboGender.TabIndex = 2;
            // 
            // TxtFamily
            // 
            this.TxtFamily.Location = new System.Drawing.Point(213, 20);
            this.TxtFamily.Name = "TxtFamily";
            this.TxtFamily.Size = new System.Drawing.Size(125, 27);
            this.TxtFamily.TabIndex = 1;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(553, 16);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(125, 27);
            this.TxtName.TabIndex = 1;
            // 
            // TxtPrescriptionDate
            // 
            this.TxtPrescriptionDate.Location = new System.Drawing.Point(553, 129);
            this.TxtPrescriptionDate.Mask = "0000/00/00";
            this.TxtPrescriptionDate.Name = "TxtPrescriptionDate";
            this.TxtPrescriptionDate.Size = new System.Drawing.Size(125, 27);
            this.TxtPrescriptionDate.TabIndex = 1;
            this.TxtPrescriptionDate.ValidatingType = typeof(System.DateTime);
            // 
            // TxtBirthDate
            // 
            this.TxtBirthDate.Location = new System.Drawing.Point(553, 71);
            this.TxtBirthDate.Mask = "00/00/0000";
            this.TxtBirthDate.Name = "TxtBirthDate";
            this.TxtBirthDate.Size = new System.Drawing.Size(125, 27);
            this.TxtBirthDate.TabIndex = 1;
            this.TxtBirthDate.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(713, 129);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "تاریخ نسخه:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 129);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "نوع بیمه:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 74);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "جنسیت:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(713, 74);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "تاریخ تولد:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(383, 23);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "نام خانوادگی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 23);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "نام:";
            // 
            // BtnInformation
            // 
            this.BtnInformation.Location = new System.Drawing.Point(314, 36);
            this.BtnInformation.Name = "BtnInformation";
            this.BtnInformation.Size = new System.Drawing.Size(211, 29);
            this.BtnInformation.TabIndex = 2;
            this.BtnInformation.Text = "جست و جو";
            this.BtnInformation.UseVisualStyleBackColor = true;
            this.BtnInformation.Click += new System.EventHandler(this.BtnInformation_Click);
            // 
            // TxtNationalCode
            // 
            this.TxtNationalCode.Location = new System.Drawing.Point(559, 36);
            this.TxtNationalCode.Mask = "0000000000";
            this.TxtNationalCode.Name = "TxtNationalCode";
            this.TxtNationalCode.Size = new System.Drawing.Size(125, 27);
            this.TxtNationalCode.TabIndex = 1;
            this.TxtNationalCode.ValidatingType = typeof(int);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 36);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "کدملی بیمار:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Doctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 609);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Doctor";
            this.Text = "Doctor";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button BtnSave;
        private ComboBox ComboInsuranceType;
        private ComboBox ComboGender;
        private TextBox TxtFamily;
        private TextBox TxtName;
        private MaskedTextBox TxtPrescriptionDate;
        private MaskedTextBox TxtBirthDate;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label2;
        private Button BtnInformation;
        private MaskedTextBox TxtNationalCode;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private GroupBox groupBox4;
        private Button BtnPrescription;
    }
}