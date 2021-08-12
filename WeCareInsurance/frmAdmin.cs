using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeCareInsurance
{
    public partial class frmAdmin : Form
    {
        private List<Policy> Policies = new List<Policy>(); //Global list storing Policies

        public frmAdmin(List<Policy> Policies)
        {//Constructor taking list of Policies
            InitializeComponent();
            this.Policies = Policies;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {//Displays all objects contained in Policies details in textbox
            int i = 0;

            txtPolicyDetails.Clear();

            while (i < Policies.Count)
            {
                txtPolicyDetails.Text = txtPolicyDetails.Text + Policies[i].details();
                i++;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {//Exits the application
            DialogResult exit = MessageBox.Show("Are you sure you wish to exit?", "", MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnFilterPolicyID_Click(object sender, EventArgs e)
        {//Displays Policies with policyID containing data entered
            int i = 0;

            txtPolicyDetails.Text = "";

            while (i < Policies.Count)
            {
                if (Policies[i].policyID.Contains(txtPolicyID.Text))
                {
                    txtPolicyDetails.Text = txtPolicyDetails.Text + Policies[i].details();
                    txtPolicyID.Clear();
                }

                i++;
            }
        }

        private void btnFilterUsage_Click(object sender, EventArgs e)
        {//Displays Policies with Usage containing data entered
            int i = 0;

            txtPolicyDetails.Text = "";

            while (i < Policies.Count)
            {
                if (Policies[i].usage.Contains(txtUsage.Text))
                {
                    txtPolicyDetails.Text = txtPolicyDetails.Text + Policies[i].details();
                    txtUsage.Clear();
                }

                i++;
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {//Opens frmMenu
            DialogResult exit = MessageBox.Show("Are you sure you wish to exit?", "", MessageBoxButtons.YesNo);

            if (exit == DialogResult.Yes)
            {
                frmMenu Menu = new frmMenu(Policies);
                Menu.Show();

                this.Hide();
            }
        }

        private void btnFilterSurname_Click(object sender, EventArgs e)
        {//Displays Policies with Surname containing data entered
            int i = 0;

            txtPolicyDetails.Text = "";

            while (i < Policies.Count)
            {
                if (Policies[i].surname.Contains(txtSurname.Text))
                {
                    txtPolicyDetails.Text = txtPolicyDetails.Text + Policies[i].details();
                    txtSurname.Clear();
                }

                i++;
            }
        }

        private void btnFilterStatus_Click(object sender, EventArgs e)
        {//Displays Policies with Status containing data entered
            int i = 0;

            txtPolicyDetails.Text = "";

            while (i < Policies.Count)
            {
                if (Policies[i].status.Contains(txtStatus.Text))
                {
                    txtPolicyDetails.Text = txtPolicyDetails.Text + Policies[i].details();
                    txtStatus.Clear();
                }

                i++;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {//Clears textbox of all policy details
            txtPolicyDetails.Text = "";
        }

        private void btnPolicyDate_Click(object sender, EventArgs e)
        {//Displays policy details for policies created on chosen date
            txtPolicyDetails.Clear();

            string date = datePolicies.Value.ToString("dd-MM-yyyy");

            string line;

            string policyID;
            string startDate;
            string forename;
            string surname;
            string occupation;
            string vehicle;
            string usage;
            string vehicleKept;
            string noOfDrivers;
            string status;
            string premium;

            try
            {
                StreamReader sr = File.OpenText("Policies" + date + ".csv");

                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    string[] values = line.Split(',');

                    policyID = "Policy ID: " + values[0];
                    startDate = "Start Date: " + values[1];
                    forename = "Forename: " + values [2];
                    surname = "Surname: " + values[3];
                    occupation = "Occupation: " + values[4];
                    vehicle = "Vehicle: " + values[5];
                    usage = "Usage: " + values[6];
                    vehicleKept = "Vehicle Kept: " + values[7];
                    noOfDrivers = "No of Drivers: " + values[8];
                    status = "Status: " + values[9];
                    premium = "Premium: £" + values[10];

                    txtPolicyDetails.Text = txtPolicyDetails.Text + policyID + "\r\n" + startDate + "\r\n" + forename + "\r\n" + surname + "\r\n" + occupation + "\r\n" + vehicle + "\r\n" + usage + "\r\n" + vehicleKept +"\r\n" +
                    noOfDrivers + "\r\n" + status + "\r\n" + premium + "\r\n\r\n";               
                 }
                 sr.Close();

                Policies.Clear(); //Clears Policy list after policies are saved
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("No Policies made on this date.");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {//Saves all policy details to csv file
            string date = DateTime.Today.ToString("dd-MM-yyyy");
            string filePath = "Policies" + date + ".csv";
            string delimiter = ",";

            StringBuilder sb = new StringBuilder();
            foreach (Policy policy in Policies)
            {
                sb.AppendLine(policy.policyID + delimiter + policy.startDate + delimiter + policy.forename + delimiter + policy.surname + delimiter + policy.occupation + delimiter
                + policy.vehicle + delimiter + policy.usage + delimiter + policy.vehicleKept + delimiter + policy.drivers.Count + delimiter + policy.status + delimiter + policy.premium);
            }

            File.WriteAllText(filePath, sb.ToString());

            MessageBox.Show("Policies saved to file.");
        }

        private void txtPolicyID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
