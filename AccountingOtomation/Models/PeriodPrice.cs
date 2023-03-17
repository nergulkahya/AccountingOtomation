using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingOtomation.Models
{
    public class PeriodPrice
    {
        public int PeriodPriceId { get; set; }
        public string StartAndStopDate { get; set; }
        public string USD { get; set; }
        public string TL { get; set; }
    }
}
