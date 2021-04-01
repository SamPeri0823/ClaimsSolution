using Claims.DataModel;
using Claims.IngestHelper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Claims.Controllers
{
   
    public class ClaimsController : ApiController
    {
        [HttpGet]
        [Route("api/claims/{dateTime}")]
        public async Task<HttpResponseMessage> GetDetailsByDateTime(DateTime date)
        {
            /// check for null date 
            try
            {
                var csvData = new CsvData();
                // id there is a db this can asychronus call
                var details = csvData.DataConvertor();
                // we can convert the details object to Json here
                return Request.CreateResponse(System.Net.HttpStatusCode.OK, FilterData(details,date));
            }
            catch(Exception ex) {
                return new HttpResponseMessage(System.Net.HttpStatusCode.InternalServerError); 
            }
        }

        /// <summary>
        ///  Helper class to filter data based on date
        /// </summary>
        /// <param name="details"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public Details FilterData(Details details, DateTime date)
        {
            // this may not need to perform in seperate method
            var Filtereddetails = new Details();
            Filtereddetails.claims = details.claims.Where(a => a.ClaimDate == date).ToList();
            Filtereddetails.members = Filtereddetails.members.Where(b => b.MemberId == b.claims.MemberId).ToList();
            return Filtereddetails;
        }
        
    }
}
