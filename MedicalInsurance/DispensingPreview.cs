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
    public partial class DispensingPreview : Form
    {
        private readonly IMedicineRepository medicineRepository;
        private readonly IPrescriptionRepository prescriptionRepository;
        private List<Medicine> medicines;

        public DispensingPreview(List<Medicine> medicines)
        {
            medicineRepository = new MedicineRepository();
            prescriptionRepository = new PrescriptionRepository();
            InitializeComponent();
            this.medicines = medicines;
        }

        private void DispensingPreview_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = medicines.ToList();
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            Prescription prescription = new Prescription()
            {
                DrId = 1,
                PrescriptionTypeId = 1,
                PationtId = 2,
                Insurance = "سلامت"
            };


            prescriptionRepository.Add(prescription);
            var id = prescriptionRepository.GetLastId();

            foreach (var medicine in medicines)
            {
                medicineRepository.Add(medicine, 1);
            }

        }
    }
}
