namespace MedicalInsurance.UI
{
    partial class Pharmacy
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
            this.txtBoxNationalCode = new System.Windows.Forms.TextBox();
            this.BtnSearchByNationalCode = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblDrName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboInsuranceType = new System.Windows.Forms.ComboBox();
            this.ComboGender = new System.Windows.Forms.ComboBox();
            this.TxtFamily = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtPrescriptionDate = new System.Windows.Forms.MaskedTextBox();
            this.TxtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxNationalCode
            // 
            this.txtBoxNationalCode.Location = new System.Drawing.Point(560, 41);
            this.txtBoxNationalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNationalCode.Name = "txtBoxNationalCode";
            this.txtBoxNationalCode.Size = new System.Drawing.Size(147, 27);
            this.txtBoxNationalCode.TabIndex = 0;
            // 
            // BtnSearchByNationalCode
            // 
            this.BtnSearchByNationalCode.Location = new System.Drawing.Point(451, 40);
            this.BtnSearchByNationalCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnSearchByNationalCode.Name = "BtnSearchByNationalCode";
            this.BtnSearchByNationalCode.Size = new System.Drawing.Size(86, 31);
            this.BtnSearchByNationalCode.TabIndex = 1;
            this.BtnSearchByNationalCode.Text = "جست و جو";
            this.BtnSearchByNationalCode.UseVisualStyleBackColor = true;
            this.BtnSearchByNationalCode.Click += new System.EventHandler(this.BtnSearchByNationalCode_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(95, 263);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(723, 331);
            this.dataGridView1.TabIndex = 2;
            // 
            // lblDrName
            // 
            this.lblDrName.AutoSize = true;
            this.lblDrName.Location = new System.Drawing.Point(635, 183);
            this.lblDrName.Name = "lblDrName";
            this.lblDrName.Size = new System.Drawing.Size(0, 20);
            this.lblDrName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = ": تاریخ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(63, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(0, 20);
            this.lblDate.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComboInsuranceType);
            this.groupBox3.Controls.Add(this.lblDrName);
            this.groupBox3.Controls.Add(this.ComboGender);
            this.groupBox3.Controls.Add(this.TxtFamily);
            this.groupBox3.Controls.Add(this.TxtName);
            this.groupBox3.Controls.Add(this.TxtPrescriptionDate);
            this.groupBox3.Controls.Add(this.TxtBirthDate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(57, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(825, 176);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(713, 128);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "تاریخ نسخه:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(383, 128);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "نوع بیمه:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 73);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "جنسیت:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(713, 73);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "تاریخ تولد:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(383, 21);
            this.label11.Name = "label11";
            this.label11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "نام خانوادگی:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(713, 21);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(30, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "نام:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(725, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = ": کد ملی مراجعه کننده";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(277, 604);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(74, 20);
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = ": قیمت کل";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(95, 601);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(167, 27);
            this.textBoxPrice.TabIndex = 11;
            // 
            // Pharmacy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 640);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnSearchByNationalCode);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtBoxNationalCode);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Pharmacy";
            this.Text = "s";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtBoxNationalCode;
        private Button BtnSearchByNationalCode;
        private DataGridView dataGridView1;
        private Label lblDrName;
        private Label label6;
        private Label lblDate;
        private GroupBox groupBox3;
        private ComboBox ComboInsuranceType;
        private ComboBox ComboGender;
        private TextBox TxtFamily;
        private TextBox TxtName;
        private MaskedTextBox TxtPrescriptionDate;
        private MaskedTextBox TxtBirthDate;
        private Label label2;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label1;
        private Label lblPrice;
        private TextBox textBoxPrice;
    }
}