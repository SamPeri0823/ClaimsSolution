using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Claims.DataModel
{
    public class ClaimModel
    {
        public string MemberId { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal CliamAmount { get; set; }
    }
}
