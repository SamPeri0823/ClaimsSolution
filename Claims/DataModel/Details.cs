using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Claims.DataModel
{
    public class Details
    {
        public List<ClaimModel> claims { get; set; }
        public List<MemberModel> members { get; set; }
    }
}
