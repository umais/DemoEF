using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEF.model.repositories
{
    public interface IRepository
    {
         void Insert(IModelObects m);
         IModelObects getItem(string id);
         List<IModelObects> getAll();
         void Update(IModelObects m);
    }
}
