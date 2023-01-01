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
        private List<Medicine> medicines;
        private int counter;

        public Dispensing()
        {
            medicines = new List<Medicine>();
            medicineRepository = new MedicineRepository();
            InitializeComponent();
            DrugTypeName();
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
            counter++;
            Medicine medicine = new Medicine
            {
                Id = counter,
                DrugName = comboBox1.Text.ToString(),
                Count = Convert.ToInt32(TxtCount.Text),
                DrugTypeId = Convert.ToInt32(ComboTypeOfDrug.SelectedValue)
            };

            medicines.Add(medicine);
            dataGridView3.DataSource = medicines.ToList();
        }

        private void PrescriptionSave_Click(object sender, EventArgs e)
        {
            DispensingPreview frm = new DispensingPreview(medicines);
            frm.Show();
        }
    }
}
