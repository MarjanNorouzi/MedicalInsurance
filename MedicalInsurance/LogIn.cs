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
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            Validate();
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

            if (RBtnDoctor.Checked)
            {
                var frm = new LogIn();
            }
            if (RBtnpharmacy.Checked)
            {

            }
            if (RBtnInsurance.Checked)
            {



            }
        }
    }
}
