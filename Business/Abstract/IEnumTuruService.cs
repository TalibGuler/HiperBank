using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEnumTuruService
    {
        IDataResult<IEnumerable<EnumTuru>> GetAll();
        IDataResult<IEnumerable<EnumTuru>> GetById(int id);
        IResult Add(EnumTuru enumTuru);
        IResult Delete(EnumTuru enumTuru);
        IResult Update(EnumTuru enumTuru);

    }
}
