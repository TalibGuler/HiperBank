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
    public interface ITuzelMusteriService
    {
        IDataResult<List<TuzelMusteri>> GetAll();
        IDataResult<List<TuzelMusteri>> GetById(int id);
        IResult Add(TuzelMusteri tuzelMusteri);
        IResult Update(TuzelMusteri tuzelMusteri);
        IResult Delete(TuzelMusteri tuzelMusteri);
        IDataResult<List<MusteriBilancoResponseDto>> GetMusteriBilancoResponseDto();
    }
}
