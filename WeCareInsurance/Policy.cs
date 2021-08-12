using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCareInsurance
{
    public class Policy
    {
        public string policyID { get; set; }
        public DateTime startDate { get; set; }
        public string forename { get; set; }
        public string surname { get; set; }
        public string occupation { get; set; }
        public string vehicle { get; set; }
        public string usage { get; set; }
        public string vehicleKept { get; set; }
        public List<Driver> drivers { get; set; }
        public string status { get; set; }
        public double premium { get; set; }

        public Policy()
        {
            this.policyID = "";
            this.startDate = DateTime.Now;
            this.forename = "";
            this.surname = "";
            this.occupation = "";
            this.vehicle = "";
            this.usage = "";
            this.vehicleKept = "";
            this.drivers = new List<Driver>();
            this.status = "";
            this.premium = 0;
        }

        public Policy(string policyID, DateTime startDate, string forename, string surname, string occupation, string vehicle, string usage, string vehicleKept, List<Driver> drivers, string status, double premium)
        {
            this.policyID = policyID;
            this.startDate = startDate;
            this.forename = forename;
            this.surname = surname;
            this.occupation = occupation;
            this.vehicle = vehicle;
            this.usage = usage;
            this.vehicleKept = vehicleKept;
            this.drivers = drivers;
            this.status = status;
            this.premium = premium;
        }

            public string details()
        {
            string details = "policyID: " + policyID + "\r\nName: " + forename + " " + surname + "\r\nOccupation: " + occupation + "\r\nVehicle: " + vehicle + "\r\nUsage: " + usage + "\r\nVehicle Kept: " + vehicleKept;

            int i = 0;
            while (i < (drivers.Count))
            {
                details = details + "\r\nDriver " + (i + 1) + ": " + drivers[i].forename + " " + drivers[i].surname + "\r\nNo of Claims: " + drivers[i].claims.Count.ToString();
                i++;
            }

            details = details + "\r\nPremium: " + premium.ToString("C") + "\r\nStatus: " + status + "\r\n\r\n\r\n";

            return details;
        }
    }
}
