using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.model
{
    public class Applicant:IModelObects
    {
        public int appID { get; set; }
        public string ApplicantName { get; set; }
        public string Applicant_MI { get; set; }
        public string ApplicantLastName { get; set; }
        public string Applicant_Residence { get; set; }
        public string Applicant_Residence_City { get; set; }
        public string Applicant_Residence_State { get; set; }
        public string Applicant_Residence_Zip { get; set; }
        public string Applicant_Mailing_Address { get; set; }
        public string Applicant_mailing_Zip { get; set; }
        public string Applicant_Mailing_City { get; set; }
        public string Applicant_Mailing_State { get; set; }
        public string Applicant_PhoneNumber { get; set; }
        public string Applicant_Email { get; set; }
        public Nullable<System.DateTime> Applicant_DOB { get; set; }
    }
}
