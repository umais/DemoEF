using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.model.repositories
{
    public static class ApplicantRepositoryExtension
    {
        public static IModelObects getApplicantByName(this IRepository r,string name){
            ApplicantSQLRepository a = (ApplicantSQLRepository) r;
           return a.FetchApplicantByname(name);
        }
    }
}
