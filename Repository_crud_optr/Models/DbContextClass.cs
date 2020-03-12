using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_crud_optr.Models
{
    public class DbContextClass : DbContext
    {
        public DbContextClass()
        { }
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {
            
        }
        public DbSet<Emp> Emp { set; get; }
        public DbSet<Dept> Dept { set; get; }
    }
}
