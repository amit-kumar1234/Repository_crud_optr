using Microsoft.EntityFrameworkCore;
using Repository_crud_optr.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using Repository_crud_optr.Models;
namespace Repository_crud_optr.Repositories
{
    public class Repo :Irepo
    {
        public readonly DbContextClass _dbcontext;
        public Repo()
        {
            _dbcontext = new DbContextClass();
        }

        public Repo(DbContextClass dbcontext)
        {
            _dbcontext = dbcontext;
        }

     public   void Delete(int id)
        {
            var ep = _dbcontext.Dept.Find(id);
            if (ep != null)
            {
                _dbcontext.Dept.Remove(ep);
            }
        }

      public  IEnumerable<Dept> GetList()
        {
           return _dbcontext.Dept.ToList();
        }

      public  Dept GetRecordById(int id)
        {
            return _dbcontext.Dept.Find(id);
        }

     public   void Insert(Dept dept)
        {
            _dbcontext.Dept.Add(dept);
            Save();
        }

       public void Save()
        {
            _dbcontext.SaveChanges();
        }

        public void Update(Dept dept)
        {
            _dbcontext.Entry(dept).State = EntityState.Modified;
        }
        private bool _disposed = false;
        public virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _dbcontext.Dispose();
                }
            }
            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        public IEnumerable<Emp> GetList1()
        {
            var v = _dbcontext.Emp.Include(c => c.Dept).AsNoTracking();
            
            return v;
        }

    }
}
