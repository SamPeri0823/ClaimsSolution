using Claims.DataModel;
using CsvHelper;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Claims.IngestHelper
{
    public class CsvData
    {
        private List<ClaimModel> claims;
        private List<MemberModel> members;
        private const string claimsFile = @"C:\Users\v-venkpe\source\repos\Claims\Claims\DataSet\Claim.csv.xlsx";
        private const string memberFile = @"C:\Users\v-venkpe\source\repos\Claims\Claims\DataSet\Member.csv.xlsx";

        public Details DataConvertor()
        {
         
            var claimReader = new StreamReader(claimsFile);
            using (var csv = new CsvReader(claimReader, CultureInfo.InvariantCulture))
            {
                claims = csv.GetRecords<ClaimModel>().ToList();
            }
            var memberReader = new StreamReader(memberFile);
            using (var csv = new CsvReader(memberReader, CultureInfo.InvariantCulture))
            {
                members = csv.GetRecords<MemberModel>().ToList();
            }
            var details = new Details {
                claims = this.claims, members = this.members };
            return details;

        }
    }
}
