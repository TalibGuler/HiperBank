using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Data;
using DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Concrete
{
    public class BilancoRepository : EfEntityRepositoryBase<Bilanco>, IBilancoRepository
    {
       
        public BilancoRepository(ProjectDbContext context) : base(context)
        {
           
        }
    }
}
