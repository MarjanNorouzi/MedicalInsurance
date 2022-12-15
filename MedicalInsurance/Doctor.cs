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
    public partial class Doctor : Form
    {
        private readonly IPatientRepository patientRepository;
        public Doctor()
        {
            patientRepository = new PatientRepository();
            InitializeComponent();
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            var dt = patientRepository.GetByNationalCode(TxtNationalCode.Text);

            if (dt.Rows.Count == 1)
            {
                dt.Select();
                Patient patient = default;
                ;
                foreach (var dataRow in dt.Select())
                {
                    patient = new Patient()
                    {
                        Name = dataRow["Name"].ToString()!,
                        Family = dataRow["Family"].ToString()!,
                        BirthDate = Convert.ToDateTime(dataRow["BirthDate"].ToString()),
                        Sexual = dataRow["Sexual"].ToString()!,
                    };
                }

                TxtName.Text = patient.Name;
                TxtFamily.Text = patient.Family;
                TxtPrescriptionDate.Text = DateTime.Now.ToString();

                //ToDo = Should Get Type Of Insurance From DateBase
                ComboInsuranceType.Text = patient.Family.ToString();
                ComboSexual.Text = patient.Sexual.ToString();
                groupBox3.Enabled = false;
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("اطلاعات بیمار را وارد کنید.");

                ComboInsuranceType.Items.Add("تامین اجتماعی");
                ComboInsuranceType.Items.Add("سلامت");

                ComboSexual.Items.Add("زن");
                ComboSexual.Items.Add("مرد");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidatePatient();
            var newPatient = new Patient();
            patientRepository.Add(newPatient);

        }

        private void ValidatePatient()
        {
            if (string.IsNullOrEmpty(TxtName.Name))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(TxtFamily.Text))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(TxtBirthDate.Text))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(TxtPrescriptionDate.Text))
                throw new ArgumentNullException();

            //if (DateTime.TryParse(TxtBirthDate, "yyyy-mm-dd", out DateTime _))
            //    throw new ArgumentNullException();
        }
    }
}
