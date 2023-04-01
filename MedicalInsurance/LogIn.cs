namespace MedicalInsurance.UI
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

        }

        public void Validate()
        {
            if (string.IsNullOrEmpty(TxtUserName.Text))
                throw new ArgumentNullException();

            if (string.IsNullOrEmpty(TxtPassword.Text))
                throw new ArgumentNullException();

        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Validate();
            if (RBtnDoctor.Checked)
            {
                var frm = new Doctor();
                frm.Show();
            }
            if (RBtnpharmacy.Checked)
            {
                var frm = new Pharmacy();
                frm.Show();
            }
            if (RBtnInsurance.Checked)
            {
                
            }
        }
    }
}
