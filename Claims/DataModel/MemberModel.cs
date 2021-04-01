using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Claims.DataModel
{
    public class MemberModel
    {
        public string MemberId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string FirstName {get;set;}
        public string LastName { get; set; }

        public ClaimModel claims { get; set; }
    }
}
