using MedicalInsurance.InfraStructrue.IRepositories;
using MedicalInsurance.InfraStructrue.Repositories;
using MedicalInsurance.Model.Models;

namespace MedicalInsurance.UI
{
    public partial class Doctor : Form
    {
        private readonly IPatientRepository patientRepository;
        public Doctor()
        {
            IsMdiContainer = true;
            patientRepository = new PatientRepository();
            InitializeComponent();
            FillComboBoxs();
        }

        private void BtnInformation_Click(object sender, EventArgs e)
        {
            groupBox3.Enabled = true;
            var dt = patientRepository.GetByNationalCode(TxtNationalCode.Text);

            if (dt.Rows.Count == 1)
            {
                FillInformationTextBoxs(dt);
                ChangeGroupBox3State(dt);
            }

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("اطلاعات بیمار را وارد کنید.");
                ChangeGroupBox3State(dt);
            }
        }

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
                    BirthDate = Convert.ToDateTime(dataRow["BirthDate"].ToString()),
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
                BtnSave.Enabled = false;
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
                BtnSave.Enabled = true;
            }
            
        }

        private void FillComboBoxs()
        {
            ComboGender.Items.Clear();
            ComboInsuranceType.Items.Clear();

            ComboInsuranceType.Items.Add("تامین اجتماعی");
            ComboInsuranceType.Items.Add("سلامت");

            ComboGender.Items.Add("زن");
            ComboGender.Items.Add("مرد");

            ComboPrescriptionType.Items.Add("دارو");
            ComboPrescriptionType.Items.Add("رادیولوژی");
            ComboPrescriptionType.Items.Add("خدمات");


            var dt2 = patientRepository.GetByNationalCode(TxtNationalCode.Text);
            dt2.Select();
            Patient patient = default!;

            foreach (var dataRow in dt2.Select())
            {
                patient = new Patient()
                {
                    Name = dataRow["Name"].ToString()!,
                    Family = dataRow["Family"].ToString()!,
                    BirthDate = Convert.ToDateTime(dataRow["BirthDate"].ToString()),
                    Gender = dataRow["Gender"].ToString()!,
                };
            }
            //Check
            //ComboPrescriptionType.Items.
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            ValidatePatient();
            string gender = "M";

            if (ComboGender.SelectedItem == "زن")
                gender = "F";

            var newPatient = new Patient()
            {
                Name = TxtName.Text,
                Family = TxtFamily.Text,
                BirthDate = Convert.ToDateTime(TxtPrescriptionDate.Text),
                Gender = gender,
                NationalCode = TxtNationalCode.Text,
            };

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

        private void BtnPrescription_Click(object sender, EventArgs e)
        {
            dispensing frm = new dispensing();
            frm.Show();
        }
    }
}
