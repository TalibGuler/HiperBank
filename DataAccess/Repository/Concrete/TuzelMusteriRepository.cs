using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
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
    public class TuzelMusteriRepository : EfEntityRepositoryBase<TuzelMusteri>, ITuzelMusteriRepository
    {
      
        public TuzelMusteriRepository(ProjectDbContext context) : base(context)
        {
           
        }
        public ProjectDbContext dbContext => context as ProjectDbContext;
        public IEnumerable<MusteriBilancoResponseDto> GetMusteriBilancoResponseDto()
        {
            
                var result = from tm in dbContext.TuzelMusteri
                             join mu in dbContext.Musteri
                             on tm.MusteriId equals mu.Id
                             join b in dbContext.Bilanco
                             on mu.Id equals b.MusteriId
                             select new MusteriBilancoResponseDto
                             {
                                 Unvan = tm.Unvan,
                                 Yetkili = tm.Yetkili,
                                 BilancoTutari = b.BilancoTutari,
                                 BilancoTarihi = b.BilancoTarihi
                             };
                return result.ToList();
            
        }
    }
}
