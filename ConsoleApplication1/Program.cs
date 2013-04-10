using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoEF.model;
using DemoEF.model.repositories;
using System.Collections;

using Ninject;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IModelObects a = new Applicant() { ApplicantName = "Umais", ApplicantLastName = "Siddiqui" };
            ninjectConfiguration n = new ninjectConfiguration();
            IRepository b = n.kernel.Get<IRepository>(); ;
           // b.Insert(a);
            a = b.getApplicantByName("Tayyab");
          
        }
    }
}
