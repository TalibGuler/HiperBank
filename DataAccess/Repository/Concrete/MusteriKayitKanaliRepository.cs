using Core;
using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using Core.Extensions;
using DataAccess.Data;
using DataAccess.Repository.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Concrete
{
    public class MusteriKayitKanaliRepository : EfEntityRepositoryBase<MusteriKayitKanali, ProjectDbContext>, IMusteriKayitKanaliRepository
    {
        public List<MusteriKayitKanaliResponseDto> GetMusteriKayitKanaliResponseDto()
        {
            using (ProjectDbContext dbContext = new ProjectDbContext())
            {
                var result = from m in dbContext.Musteri
                             join mkk in dbContext.MusteriKayitKanali
                             on m.Id equals mkk.MusteriId
                             //join e in dbContext.Enum
                             //on mkk.KayitTuruId equals e.Id
                             join gm in dbContext.GercekMusteri
                             on m.Id equals gm.MusteriId
                             select new MusteriKayitKanaliResponseDto
                             {
                                 Id= m.Id,
                                 Ad = gm.Ad,
                                 Soyad= gm.Soyad,
                                 KayitTuruId=mkk.KayitTuruId,
                                 KayıtTuruAdı=EnumExtensions.GetDisplayName((MusteriKayitTuru)mkk.KayitTuruId)
                             };
                return result.ToList();
            }

        }
    }
}
