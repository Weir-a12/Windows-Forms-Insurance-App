using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeCareInsurance
{
    public partial class frmMenu : Form
    {
        private List<Policy> Policies = new List<Policy>(); //List that stores Policies

        public frmMenu()
        {
            InitializeComponent();
        }

        public frmMenu(List<Policy> Policies)
        {//Constructor taking list of Policies
            InitializeComponent();
            this.Policies = Policies;
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {//Opens frmQuote
            frmQuote Menu = new frmQuote(Policies);
            Menu.Show();

            this.Hide();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {//Opens frmAdmin
            if(txtPassword.Text == "admin")
            {
                frmAdmin Menu = new frmAdmin(Policies);
                Menu.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {//Exits the Application
            DialogResult exit = MessageBox.Show("Are you sure you wish to exit?", "", MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
