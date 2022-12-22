namespace MedicalInsurance.UI
{
    partial class Dispensing
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
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ComboTypeOfDrug = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DrugSave = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RadiologySave = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ServiceSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDosage = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.Location = new System.Drawing.Point(41, 607);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(94, 29);
            this.BtnConfirm.TabIndex = 0;
            this.BtnConfirm.Text = "ثبت نهایی";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "اطلاعات نسخه دارویی";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(31, 49);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(725, 528);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.TxtDosage);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.TxtCount);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.comboBox3);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.comboBox4);
            this.tabPage1.Controls.Add(this.ComboTypeOfDrug);
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.DrugSave);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 495);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "دارو";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(6, 358);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.Size = new System.Drawing.Size(705, 101);
            this.dataGridView3.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(242, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "شکل دارو:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(598, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "دستورات متفرقه";
            // 
            // TxtCount
            // 
            this.TxtCount.Location = new System.Drawing.Point(397, 69);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(195, 27);
            this.TxtCount.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(609, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "تعداد:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(242, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "مقادیر مصرف:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(30, 158);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(195, 28);
            this.comboBox3.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(609, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "زمان مصرف:";
            // 
            // ComboTypeOfDrug
            // 
            this.ComboTypeOfDrug.FormattingEnabled = true;
            this.ComboTypeOfDrug.Location = new System.Drawing.Point(30, 69);
            this.ComboTypeOfDrug.Name = "ComboTypeOfDrug";
            this.ComboTypeOfDrug.Size = new System.Drawing.Size(195, 28);
            this.ComboTypeOfDrug.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(397, 157);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 28);
            this.comboBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(609, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام دارو:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1111",
            "2222",
            "3333",
            "4444",
            "5555"});
            this.comboBox1.Location = new System.Drawing.Point(30, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(562, 28);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DrugSave
            // 
            this.DrugSave.Location = new System.Drawing.Point(6, 323);
            this.DrugSave.Name = "DrugSave";
            this.DrugSave.Size = new System.Drawing.Size(105, 29);
            this.DrugSave.TabIndex = 0;
            this.DrugSave.Text = "ثبت";
            this.DrugSave.UseVisualStyleBackColor = true;
            this.DrugSave.Click += new System.EventHandler(this.DrugSave_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.RadiologySave);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(717, 495);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "رادیولوژی";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(682, 385);
            this.dataGridView1.TabIndex = 2;
            // 
            // RadiologySave
            // 
            this.RadiologySave.Location = new System.Drawing.Point(6, 460);
            this.RadiologySave.Name = "RadiologySave";
            this.RadiologySave.Size = new System.Drawing.Size(94, 29);
            this.RadiologySave.TabIndex = 1;
            this.RadiologySave.Text = "ثبت";
            this.RadiologySave.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.ServiceSave);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(717, 495);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "خدمات";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(28, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(667, 330);
            this.dataGridView2.TabIndex = 2;
            // 
            // ServiceSave
            // 
            this.ServiceSave.Location = new System.Drawing.Point(6, 460);
            this.ServiceSave.Name = "ServiceSave";
            this.ServiceSave.Size = new System.Drawing.Size(94, 29);
            this.ServiceSave.TabIndex = 1;
            this.ServiceSave.Text = "ثبت";
            this.ServiceSave.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "ثبت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DrugSave_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 226);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(573, 91);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "دوز:";
            // 
            // TxtDosage
            // 
            this.TxtDosage.Location = new System.Drawing.Point(397, 114);
            this.TxtDosage.Name = "TxtDosage";
            this.TxtDosage.Size = new System.Drawing.Size(195, 27);
            this.TxtDosage.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(242, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "دوز فرم:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "mg",
            "percent"});
            this.comboBox4.Location = new System.Drawing.Point(30, 114);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(195, 28);
            this.comboBox4.TabIndex = 1;
            // 
            // dispensing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 664);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnConfirm);
            this.Name = "dispensing";
            this.Text = "Prescription";
            this.Load += new System.EventHandler(this.Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnConfirm;
        private Label label1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label5;
        private Label label8;
        private TextBox TxtCount;
        private Label label3;
        private Label label7;
        private ComboBox comboBox3;
        private Label label6;
        private ComboBox comboBox2;
        private Label label2;
        private ComboBox comboBox1;
        private Button DrugSave;
        private Button RadiologySave;
        private TabPage tabPage3;
        private Button ServiceSave;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private ComboBox ComboTypeOfDrug;
        private Button button1;
        private RichTextBox richTextBox1;
        private TextBox TxtDosage;
        private Label label9;
        private Label label4;
        private ComboBox comboBox4;
    }
}