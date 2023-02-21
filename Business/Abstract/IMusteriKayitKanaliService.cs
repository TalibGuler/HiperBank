using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMusteriKayitKanaliService
    {
        IDataResult<IEnumerable<MusteriKayitKanali>> GetAll();
        IDataResult<IEnumerable<MusteriKayitKanali>> GetById(int id);
        IResult Add(MusteriKayitKanali musteriKayitKanali);
        IResult Delete(MusteriKayitKanali musteriKayitKanali);
        IResult Update(MusteriKayitKanali musteriKayitKanali);
        IDataResult<IEnumerable<MusteriKayitKanaliResponseDto>> GetMusteriKayitKanaliResponseDto();
    }
}
