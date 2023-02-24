using Core.DataAccess.EntityFramework;
using Core.Entities;
using Core.Entities.Concrete;
using DataAccess.Data;
using DataAccess.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Concrete
{
    public class GercekMusteriRepository : EfEntityRepositoryBase<GercekMusteri>,IGercekMusteriRepository
    {
       
        public GercekMusteriRepository(ProjectDbContext context) : base(context)
        {

        }

        //public ProjectDbContext DbContext => context as ProjectDbContext;
        //public bool DeleteByEntity(GercekMusteri gercekMusteri)
        //{
        //    try
        //    {
        //        DbContext.GercekMusteri.Update(gercekMusteri);
        //        context.SaveChangesAsync();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}
    }
}
