using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGercekMusteriService
    {
        IDataResult<IEnumerable<GercekMusteri>> GetAll();
        IDataResult<IEnumerable<GercekMusteri>> GetById(int id);
        IResult Add(GercekMusteri gercekMusteri);
        IResult Delete(GercekMusteri gercekMusteri);
        //DataResult<GercekMusteri> DeleteById(int ogrenciId);
        IResult DeleteById(int ogrenciId);
        IResult Update(GercekMusteri gercekMusteri);

    }
}
