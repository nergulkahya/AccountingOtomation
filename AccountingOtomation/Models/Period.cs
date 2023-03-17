using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountingOtomation.Models
{
    public class Period
    {
        public int PeriodId { get; set; }
        public string PeriodName { get; set; }
        public string PeriodDate { get; set; }
        public List<PeriodPrice> PeriodPrice { get; set; }
    }
}
