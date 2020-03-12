using Repository_crud_optr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_crud_optr.Repositories
{
  public  interface Irepo
    {
        IEnumerable<Dept> GetList();
        Dept GetRecordById(int id);
        void Insert(Dept emp);
        void Update( Dept emp);
        void Delete(int id);
        void Save();
        IEnumerable<Emp> GetList1();
    }
}
