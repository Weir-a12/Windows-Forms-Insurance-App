using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeCareInsurance
{
    public class Driver
    {
        public string forename { get; set; }
        public string surname { get; set; }
        public DateTime dob { get; set; }
        public List<Claim> claims { get; set; }

        public Driver()
        {
            this.forename = "";
            this.surname = "";
            this.dob = DateTime.Now;
            this.claims = new List<Claim>();
        }

        public Driver(string forename, string surname, DateTime dob, List<Claim> claims)
        {
            this.forename = forename;
            this.surname = surname;
            this.dob = dob;
            this.claims = claims;
        }

        public int getAge()
        {
            int age = 0;

            return age;
        }
    }
}
