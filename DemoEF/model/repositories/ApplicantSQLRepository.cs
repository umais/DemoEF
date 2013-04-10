using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEF;
namespace DemoEF.model.repositories
{
    public class ApplicantSQLRepository:IRepository
    {
        MyTestDbEntities d;

        public ApplicantSQLRepository()
        {
             d = new MyTestDbEntities();
            d.Database.Connection.ConnectionString = "data source=localhost;initial catalog=AnothertestDB;user id=sa;password=Karachi@8681;MultipleActiveResultSets=True;App=EntityFramework";
        }

        public void Insert(IModelObects m){
            
            d.Applicants.Add((Applicant)m);
            d.SaveChanges();
        }

        public IModelObects getItem(string id)
        {
            int applicantId = Convert.ToInt32(id);
            return d.Applicants.Where(x=>x.appID==applicantId).FirstOrDefault();
            
        }
        public List<IModelObects> getAll(){

            return d.Applicants.ToList<IModelObects>();
        }
       public  void Update(IModelObects m)
        {
           
        }

         public IModelObects FetchApplicantByname(string name)
        {
            
            return d.Applicants.Where(x=>x.ApplicantName==name).FirstOrDefault();
            
        }
        
    }
}
