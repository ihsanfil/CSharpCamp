using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.Models
{
    public class BankProcess
    {
        public int BankProcessId { get; set; }
        public string Description { get; set; }
        public DateTime ProcessDate { get; set; }
        public string ProcessType { get; set; }
        public decimal Amount { get; set; }
        public Bank Bank { get; set; }
        public int BankId { get; set; }

    }
}
