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


        public Dispensing()
        {
            medicines = new List<Medicine>();
            medicineRepository = new MedicineRepository();
            InitializeComponent();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //to do : search in drugs list
            comboBox1.FindStringExact(Text);
        }

        private void Form_Load(object sender, EventArgs e)
        {
            var dt = medicineRepository.GetMedicineType();

            KeyValue keyValue = default!;
            List<KeyValue> list = new List<KeyValue>();

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

            Medicine medicine = new Medicine
            {
                DrugName = comboBox1.Text,
                Count = Convert.ToInt32(TxtCount.Text),
                Dosage = Convert.ToInt32(TxtDosage.Text)
            };

            medicines.Add(medicine);

            //medicineRepository.Add();
        }
    }
}
