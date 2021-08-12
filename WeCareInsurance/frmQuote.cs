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
    public partial class frmQuote : Form
    {
        private List<Policy> Policies = new List<Policy>(); //Stores Policies
        private List<Driver> Drivers = new List<Driver>(); //Stores Drivers
        private List<Claim> Claims = new List<Claim>(); //Stores Claims
        private List<string> vehicles = new List<string>(); //Stores Vehicles
        private List<double> vehicleIncrease = new List<double>(); //Stores Vehicle Increase Percentages
        private List<string> occupation = new List<string>(); //Stores Occupations
        private List<double> occupationIncrease = new List<double>(); // Stores Occupation Increase Percentages

        public frmQuote(List<Policy> Policies)
        {
            InitializeComponent();
            this.Policies = Policies;
        }

        private void frmQuote_Load(object sender, EventArgs e)
        {
            addItems();

            DateTime date = DateTime.Now;
            dateStart.MinDate = new DateTime(date.Year, date.Month, date.Day + 1); //Ensures policy minimum start date is tomorrow
            dateStart.Value = new DateTime(date.Year, date.Month, date.Day + 1);

            dateClaim.MaxDate = new DateTime(date.Year, date.Month, date.Day);
            dateClaim.Value = new DateTime(date.Year, date.Month, date.Day);

            dateDOB.MaxDate = new DateTime(date.Year, date.Month, date.Day);
            dateDOB.Value = new DateTime(date.Year, date.Month, date.Day);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {//Returns user to frmMenu
            DialogResult answer = MessageBox.Show("Are you sure you wish to return to the menu?", "", MessageBoxButtons.YesNo);

            if (answer == DialogResult.Yes)
            {
                frmMenu Menu = new frmMenu(Policies);
                Menu.Show();

                this.Hide();
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

        private void btnAddDriver_Click(object sender, EventArgs e)
        {//Adds Driver to List

            if(txtDriverForename.Text.Length >= 3)
            {//Ensures Forename is entered
                if(txtDriverSurname.Text.Length >= 3)
                {//Ensures Surname is entered
                    if (Drivers.Count < 5)
                    {//Ensures that less than 5 drivers have been added

                        int i = 0;

                        List<Claim> claims = new List<Claim>(); //Local list of claims used when creating Driver object

                        while (i < Claims.Count)
                        {//Adds items from global list to list
                            claims.Add(Claims[i]);
                            i++;
                        }

                        Driver driver = new Driver(txtDriverForename.Text, txtDriverSurname.Text, dateDOB.Value, claims); //Creates new driver object

                        Drivers.Add(driver); //adds new object to list

                        MessageBox.Show("Driver Added.");

                        Claims.Clear();//Clears global claims list

                        txtDriverForename.Clear(); //Clears Textboxes
                        txtDriverSurname.Clear();
                        dateDOB.ResetText();
                    }
                    else
                    {
                        MessageBox.Show("You have already added the maximum number of drivers");
                    }
                }
                else
                {
                    MessageBox.Show("Driver's Surname must be at least 3 characters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Driver's Forename must be at least 3 characters", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        private void btnAddClaim_Click(object sender, EventArgs e)
        {//Adds claim to list

            Claim claim = new Claim(dateClaim.Value); //Creates new claim object
            Claims.Add(claim);//adds new object to list

            MessageBox.Show("Claim Added.");

            dateClaim.ResetText();//Resets claim date
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(txtForename.Text.Length >= 3)
            {//Ensures forename is entered
                if(txtSurname.Text.Length >= 3)
                {//Ensures surname is entered
                    if(comboOccupation.Text != "")
                    {//Ensures an occupation is chosen
                        if(comboVehicle.Text != "" || txtOther.Text != "")
                        {//Ensures a vehicle is chosen/entered
                            if(comboUsage.Text != "")
                            {//Ensures a usage is chosen
                                if(comboVehicleKept.Text != "")
                                {//Ensures where the vehicle is kept has been chosen
                                    if(Drivers.Count == 0)
                                    {//Ensures at least 1 driver is added to the policy
                                        MessageBox.Show("You must add at least 1 driver.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        addPolicy(); //Adds policy if all data is valid
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Must enter where your vehicle is kept.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Must enter usage.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Must enter a vehicle.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Must choose an occupation.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Surname must be at least 3 characters.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Forename must be at least 3 characters.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAnotherQuote_Click(object sender, EventArgs e)
        {//User clicks to create new policy
            newQuote();
        }      

        public void addItems()
        {//Adds items to combo boxes

            string line; //Stores each line of csv file
            string[] values; //Stores each value in line

            StreamReader sr = File.OpenText("CarInsuranceCategories.csv"); //Stream Reader to read csv file
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                values = line.Split(',');

                vehicles.Add(values[0]); //Adds items to vehicle list
                vehicleIncrease.Add(double.Parse(values[1])); //Adds percentage increases to list

                comboVehicle.Items.Add(values[0]); //Adds vehicles to combo box
            }
            sr.Close();

            sr = File.OpenText("JobList.csv");
            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                values = line.Split(',');

                occupation.Add(values[0]); //Adds items to occupation list
                occupationIncrease.Add(double.Parse(values[1])); //Adds percentage increases to list

                comboOccupation.Items.Add(values[0]); //Adds Occupations to combo box
            }
            sr.Close();

            comboVehicleKept.Items.Add("Public Road"); //Adds items to combo box
            comboVehicleKept.Items.Add("Private Drive");
            comboVehicleKept.Items.Add("Garage");

            comboUsage.Items.Add("Social & Domestic Pleasure"); //Adds items to combo box
            comboUsage.Items.Add("Social & Commuting");
            comboUsage.Items.Add("Business");
        }      

        public int getAge(DateTime dob)
        {//returns the age of the driver
            int age;
            DateTime policyStart = dateStart.Value;

            age = policyStart.Year - dob.Year;

            if (policyStart.Month < dob.Year || policyStart.Month == dob.Month && policyStart.Day < dob.Day)
            {
                age--;
                return age;
            }
            else
            {
                return age;
            }
        }

        public int getOldest()
        {//Returns the age of the oldest driver in list Drivers
            int oldest = 0;
            int i = 0;

            while (i < Drivers.Count)
            {
                if (getAge(Drivers[i].dob) > oldest)
                {
                    oldest = getAge(Drivers[i].dob);
                }

                i++;
            }

            return oldest;
        }

        public int getYoungest()
        {//Returns the age of the youngest driver in list Drivers
            int youngest = 500;
            int i = 0;

            while (i < Drivers.Count)
            {
                if (getAge(Drivers[i].dob) < youngest)
                {
                    youngest = getAge(Drivers[i].dob);
                }

                i++;
            }

            return youngest;
        }

        public string getPolicyID()
        {//Returns the policy id with the first 3 letters of surname plus an incrementing 6-digit number
            int policyNo = Policies.Count;
            policyNo = policyNo + 1;

            string policyID = txtSurname.Text.Substring(0, 3).ToLower() + policyNo.ToString().PadLeft(6, '0');

            return policyID;
        }

        private void addPolicy()
                {//Adds a policy to the list Policies

                    Policy policy; //Local policy object which is added to list
                    List<Driver> drivers = new List<Driver>(); //Local list of drivers used in creation of Policy object
                    string vehicle = ""; //Stores vehicle depending on whether it's in the combo box or not
                    string status = ""; //Stores the status of the Policy
                    int totalClaims = 0; //Stores total number of claims on Policy
                    int i = 0; //While loop counter
                    DialogResult answer;

                    if (txtOther.Text != "")
                    {//If vehicle is entered rather than chosen from combo box
                        vehicle = txtOther.Text;
                        status = "Investigate";
                    }
                    else
                    {//If vehicle chosen from combo box
                        status = "Processed";
                        vehicle = comboVehicle.Text;
                    }

                    while (i < Drivers.Count)
                    {//Adds drivers from global list to local list
                        drivers.Add(Drivers[i]);
                        i++;
                    }

                    if (getYoungest() < 21)
                    {//Declines policy if youngest driver is under 21
                        status = "Held";
                        MessageBox.Show("Policy declined due to age of Youngest Driver");

                        answer = MessageBox.Show("Do you want to get another quote?", "", MessageBoxButtons.YesNo);

                        if (answer == DialogResult.Yes) //If user wants to get another quote
                        {
                            newQuote();
                        }
                        else if(answer == DialogResult.No)
                        {
                            MessageBox.Show("Returning to Menu...");
                            frmMenu Menu = new frmMenu(Policies);
                            Menu.Show();

                            this.Hide();
                        }
                    }
                    else if (getOldest() > 75)
                    {//Declines policy if oldest driver is over 75
                        status = "Held";
                        MessageBox.Show("Policy declined due to age of Oldest Driver");

                        answer = MessageBox.Show("Do you want to get another quote?", "", MessageBoxButtons.YesNo);
                
                        if(answer == DialogResult.Yes)
                        {
                            newQuote();
                        }
                        else if(answer == DialogResult.No)
                        {
                            MessageBox.Show("Returning to Menu...");
                            frmMenu Menu = new frmMenu(Policies);
                            Menu.Show();

                            this.Hide();
                        }
                    }
                    else
                    {
                        i = 0;
                        while(i < Drivers.Count)
                        {
                            totalClaims = totalClaims + Drivers[i].claims.Count;
                            if(totalClaims > 3)
                            {//Declines policy if total claims on policy is greater than 3
                                status = "Held";
                                MessageBox.Show("Policy declined due to having more than 3 total claims.");
                            }
                            else
                            {
                                if (Drivers[i].claims.Count > 2)
                                {//Declines policy if any one driver has more than 2 claims
                                    status = "Held";
                                    MessageBox.Show("Driver: " + Drivers[i].forename + " " + Drivers[i].surname + " has more than 2 claims.", "Policy Declined", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    break;
                                }                  
                            }

                            i++;
                        }               
                    }

                    if(status == "Held")
                    {//Creates Policy with premium of 0, but does not show quote
                        policy = new Policy(getPolicyID(), dateStart.Value, txtForename.Text, txtSurname.Text, comboOccupation.Text, vehicle, comboUsage.Text, comboVehicleKept.Text, drivers, status, 0);
                        Policies.Add(policy);//Adds policy to list
                        clearData();//Clears entered data
                        Drivers.Clear();//Clears global Drivers List
                        Claims.Clear();//Clears global Claims List
                    }
                    else if(status == "Investigate")
                    {//Creates Policy with premium of 0, but does not show quote
                        MessageBox.Show("We will investigate your policy on this vehicle and get back to you.");
                        policy = new Policy(getPolicyID(), dateStart.Value, txtForename.Text, txtSurname.Text, comboOccupation.Text, vehicle, comboUsage.Text, comboVehicleKept.Text, drivers, status, 0);
                        Policies.Add(policy);
                        clearData();//Clears entered data
                        Drivers.Clear();//Clears global Drivers List
                        Claims.Clear();// Clears global Claims List
                    }
                    else if(status == "Processed")
                    {//Creates Policy and shows the quote
                        policy = new Policy(getPolicyID(), dateStart.Value, txtForename.Text, txtSurname.Text, comboOccupation.Text, vehicle, comboUsage.Text, comboVehicleKept.Text, drivers, status, calcPremium());
                        Policies.Add(policy);//Adds policy to list

                        clearData();//Clears entered data

                        txtQuote.Text = "Premium: " + policy.premium.ToString("C");//Adds premium to quote textbox

                        Policies.Add(policy);//Adds policy to list
                        Drivers.Clear();//Clears global Drivers List
                        Claims.Clear();//Clears global Claims List
              
                        MessageBox.Show("Calculating...");
                        showQuote(); //Shows quote
                
                    }
                }

        public double calcPremium()
        {//Calculates the premium of a policy

            double premium = 300;
            int oldest = getOldest(); //Stores age of oldest driver
            int youngest = getYoungest(); //Stores age of youngest driver
            int i = 0;

            premium = premium + (premium * (vehicleIncrease[comboVehicle.SelectedIndex] / 100)); //Increases premium based on vehicle chosen

            if (comboVehicleKept.SelectedIndex == 0) //Increases premium based on where the vehicle is kept
            {
                premium = premium + (premium * 0.10);
            }
                else if (comboVehicleKept.SelectedIndex == 1)
                {
                    premium = premium + (premium * 0.05);
                }
                else
                {
                    premium = premium + (premium * 0.00);
                }


                premium = premium + (premium * (occupationIncrease[comboOccupation.SelectedIndex] / 100));  //Increases premium based on occupation chosen


                if (comboUsage.SelectedIndex == 0) //Increases premium based on usage chosen
                {
                    premium = premium + (premium * 0.00);
                }
                else if (comboUsage.SelectedIndex == 1)
                {
                        premium = premium + (premium * 0.05);
                }
                else if (comboUsage.SelectedIndex == 2)
                {
                        premium = premium + (premium * 0.10);
                }

                if (youngest >= 21 && youngest <= 25) //Increases/Decreases premium based on the age of the youngest driver
                {
                    premium = premium + (premium * 0.2);
                }
                else if (youngest >= 26 && youngest <= 75)
                {
                    premium = premium - (premium * 0.1);
                }

                while(i < Drivers.Count) //Increases premium for every claim on the policy based on the age of the claim
                {
                    for(int l = 0; l < Drivers[i].claims.Count; l++)
                    {
                        if(claimAge(Drivers[i].claims[l].date) < 1)
                        {
                            premium = premium + (premium * 0.2);
                        }
                        else if(claimAge(Drivers[i].claims[l].date) > 1 && claimAge(Drivers[i].claims[l].date) < 5)
                        {
                            premium = premium + (premium * 0.1);
                        }
                    }
                    i++;
                }
                return premium;

        }

        public void showQuote()
        {//Shows the user's quote should the policy be accepted
            grpPolicy.Hide();
            grpDriver.Hide();
            btnConfirm.Hide();

            grpQuote.Location = new Point(156, 74);
        }

        public double claimAge(DateTime claimDate)
        {//Returns the age of a claim
            int age;
            DateTime policyStart = dateStart.Value;

            age = policyStart.Year - claimDate.Year;

            if (policyStart.Month < claimDate.Year || policyStart.Month == claimDate.Month && policyStart.Day < claimDate.Day)
            {
                age--;
                return age;
            }
            else
            {
                return age;
            }
        }

        public void newQuote()
        {//Returns user to the detail entry form          
            grpPolicy.Show();
            grpDriver.Show();
            btnConfirm.Show();
            txtQuote.Clear();
            grpQuote.Location = new Point(740, 84);
        }

        public void clearData()
        {//Clears all entered data on the form
            dateStart.ResetText();
            txtForename.Clear();
            txtSurname.Clear();
            comboOccupation.SelectedIndex = -1;
            comboVehicle.SelectedIndex = -1;
            txtOther.Clear();
            comboUsage.SelectedIndex = -1;
            comboVehicleKept.SelectedIndex = -1;
            txtDriverForename.Clear();
            txtDriverSurname.Clear();
            dateDOB.ResetText();
            dateClaim.ResetText();
        }

        private void txtOther_TextChanged(object sender, EventArgs e)
        {//Ensures both comboVehicle and txtOther cannot contain a value simultaneosly
            comboVehicle.SelectedIndex = -1;
        }

        private void comboVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {//Ensures both comboVehicle and txtOther cannot contain a value simultaneosly
            txtOther.Text = "";
        }
    }
}
