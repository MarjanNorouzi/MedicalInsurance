using MedicalInsurance.InfraStructrue.IRepositories;
using MedicalInsurance.InfraStructrue.Repositories;
using MedicalInsurance.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalInsurance.UI
{
    public partial class Dispensing : Form
    {

        private readonly IMedicineRepository medicineRepository;
        private readonly IPrescriptionRepository prescriptionRepository;
        private List<Medicine> medicines;
        private int counter;
        Prescription prescription;

        public Dispensing(Prescription prescription)
        {
            medicines = new List<Medicine>();
            medicineRepository = new MedicineRepository();
            prescriptionRepository = new PrescriptionRepository();
            InitializeComponent();
            DrugTypeName();
            this.prescription = prescription;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to do : search in drugs list
            comboBox1.FindStringExact(Text);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            KeyValue keyValue;
            List<KeyValue> list;
            FillTypeOfDrug(out keyValue, out list);

            list.Clear();
            FillDrugsName(keyValue, list);


        }

        private void DrugTypeName()
        {
            var a = ComboTypeOfDrug.SelectedIndex;
            ComboTypeOfDrug.ResetText();
        }

        private void FillDrugsName(KeyValue keyValue, List<KeyValue> list)
        {
            var dt = medicineRepository.GetAll("");

            foreach (var dataRow in dt.Select())
            {
                keyValue = new KeyValue()
                {
                    Value = Convert.ToInt32(dataRow["Value"].ToString()),
                    Key = dataRow["Key"].ToString(),
                };
                list.Add(keyValue);
            }

            comboBox1.DataSource = list;
            comboBox1.ValueMember = "Value";
            comboBox1.DisplayMember = "Key";
        }

        private void FillTypeOfDrug(out KeyValue keyValue, out List<KeyValue> list)
        {
            var dt = medicineRepository.GetMedicineType();

            keyValue = default!;
            list = new List<KeyValue>();
            foreach (var dataRow in dt.Select())
            {
                keyValue = new KeyValue()
                {
                    Value = Convert.ToInt32(dataRow["Value"].ToString()),
                    Key = dataRow["Key"].ToString(),
                };
                list.Add(keyValue);
            }
            ComboTypeOfDrug.DataSource = list;
            ComboTypeOfDrug.ValueMember = "Value";
            ComboTypeOfDrug.DisplayMember = "Key";
        }

        private void DrugSave_Click(object sender, EventArgs e)
        {
            //to do
            if (TxtCount.Text == null)
                MessageBox.Show("تعداد را وارد کنید");

            else
            {
                counter++;

                Medicine medicine = new Medicine
                {
                    Id = counter,
                    DrugName = comboBox1.Text.ToString(),
                    Count = Convert.ToInt32(TxtCount.Text),
                    DrugTypeId = Convert.ToInt32(ComboTypeOfDrug.SelectedValue)
                };

                var existMedicine = medicines.FirstOrDefault(p => p.DrugName == medicine.DrugName);

                if (existMedicine != null)
                    existMedicine.Count += medicine.Count;

                else
                    medicines.Add(medicine);

                dataGridView3.DataSource = medicines.ToList();
                dataGridView3.Columns["Id"].Visible = false;
                dataGridView3.Columns["DrugName"].HeaderCell.Value = "نام دارو";
                dataGridView3.Columns["Count"].HeaderCell.Value = "تعداد";
                dataGridView3.Columns["DrugTypeId"].HeaderCell.Value = "نوع دارو";
            }
        }

        private void PrescriptionSave_Click(object sender, EventArgs e)
        {
            prescription.PrescriptionTypeId = 1;

            prescriptionRepository.Add(prescription);

            var id = Convert.ToInt32(prescriptionRepository.GetLastId());

            foreach (var medicine in medicines)
                medicineRepository.Add(medicine, id);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var a = dataGridView3.Columns["Delete"].Index;

            if (e.ColumnIndex == a)
            {
                var cellValue = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells["Id"].Value.ToString());
                var aa = medicines.FindIndex(x => x.Id == cellValue);
                medicines.RemoveAt(aa);
                dataGridView3.DataSource = medicines.ToList();
            }
        }

        private void RadiologySave_Click(object sender, EventArgs e)
        {
            prescription.PrescriptionTypeId = 2;

            prescriptionRepository.Add(prescription);
        }

        private void ServiceSave_Click(object sender, EventArgs e)
        {
            prescription.PrescriptionTypeId = 3;

            prescriptionRepository.Add(prescription);
        }
    }
}
