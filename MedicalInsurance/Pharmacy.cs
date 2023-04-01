using MedicalInsurance.InfraStructrue.IRepositories;
using MedicalInsurance.InfraStructrue.Repositories;
using MedicalInsurance.Model.Models;
using System.Globalization;

namespace MedicalInsurance.UI
{
    public partial class Pharmacy : Form
    {
        private readonly IPharmacyRepository pharmacyRepository;
        private readonly IPatientRepository patientRepository;
        private bool patientExist = false;
        public Pharmacy()
        {
            InitializeComponent();
            pharmacyRepository = new PharmacyRepository();
            patientRepository = new PatientRepository();
            ShowTime();
        }

        private void BtnInformation()
        {
            groupBox3.Enabled = true;
            var dt = patientRepository.GetByNationalCode(txtBoxNationalCode.Text);

            if (dt.Rows.Count == 1)
            {
                FillInformationTextBoxs(dt);
                ChangeGroupBox3State(dt);
                patientExist = true;
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("اطلاعات بیمار را وارد کنید.");
                ChangeGroupBox3State(dt);
            }
        }

        private void BtnSearchByNationalCode_Click(object sender, EventArgs e)
        {

            BtnInformation();
            int i = int.Parse(txtBoxNationalCode.Text);
            var medicine = pharmacyRepository.GetMedicineFromNationalCode("Usp_Pharmacy_GetByNationalCode", i);
            dataGridView1.DataSource = medicine;
            textBoxPrice.Text = Convert.ToString(SumOfThePrice());
        }

        private double SumOfThePrice()
        {

            double sum = 0;
            double result = 0;

            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                result = double.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()) *
                    double.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());

                sum += result;
            }
            return sum;
        }

        private void ShowTime()
        {
            PersianCalendar pc = new PersianCalendar();
            DateTime d = DateTime.Now;
            lblDate.Text = string.Format("{0}/{1}/{2}", pc.GetYear(d), pc.GetMonth(d), pc.GetDayOfYear(d));
        }

        //Usp_Patient_Add

        private void FillInformationTextBoxs(System.Data.DataTable dt)
        {
            dt.Select();
            Patient patient = default!;

            foreach (var dataRow in dt.Select())
            {
                patient = new Patient()
                {
                    Name = dataRow["Name"].ToString()!,
                    Family = dataRow["Family"].ToString()!,
                    BirthDate = dataRow["BirthDate"].ToString(),
                    Gender = dataRow["Gender"].ToString()!,
                };
            }

            TxtName.Text = patient.Name;
            TxtFamily.Text = patient.Family;
            TxtPrescriptionDate.Text = DateTime.Now.ToString();

            //ToDo = Should Get Type Of Insurance From DateBase
            ComboInsuranceType.SelectedIndex = 0;

            if (patient?.Gender.ToString() == "F")
                ComboGender.SelectedItem = "زن";
            else
                ComboGender.SelectedItem = "مرد";
        }

        private void ChangeGroupBox3State(System.Data.DataTable dt)
        {

            if (dt.Rows.Count == 1)
            {
                TxtName.ReadOnly = true;
                TxtFamily.ReadOnly = true;
                TxtPrescriptionDate.ReadOnly = true;
                TxtBirthDate.ReadOnly = true;
                ComboGender.Enabled = false;
                ComboInsuranceType.Enabled = false;

            }
            if (dt.Rows.Count == 0)
            {
                TxtName.Clear();
                TxtFamily.Clear();
                TxtPrescriptionDate.Clear();
                TxtBirthDate.Clear();
                ComboGender.ResetText();
                ComboInsuranceType.ResetText();

                TxtName.ReadOnly = false;
                TxtFamily.ReadOnly = false;
                TxtPrescriptionDate.ReadOnly = false;
                TxtBirthDate.ReadOnly = false;
                ComboGender.Enabled = true;
                ComboInsuranceType.Enabled = true;

            }

        }


    }

}