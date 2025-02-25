﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCrm.Models
{
    public class Bill
    {
        public int BillId { get; set; }
        public string BillTitle { get; set; }
        public decimal BillAmount { get; set; }
        public string BillPeriod { get; set; }
    }
}
