using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeCareInsurance
{
    public class Claim
    {
        public DateTime date { get; set; }

        public Claim()
        {
            this.date = DateTime.Now;
        }

        public Claim(DateTime date)
        {
            this.date = date;
        }
    }
}
