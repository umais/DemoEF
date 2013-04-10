using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using DemoEF.model.repositories;
namespace ConsoleApplication1
{
   public  class ninjectConfiguration
    {
        public IKernel kernel;

       public  ninjectConfiguration()
        {
            kernel= new StandardKernel();
            AddBindings();
        }

        private void AddBindings(){

            kernel.Bind<IRepository>().To<ApplicantSQLRepository>();
        }
    }
}
