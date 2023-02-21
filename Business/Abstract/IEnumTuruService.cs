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
        IDataResult<List<EnumTuru>> GetAll();
        IDataResult<List<EnumTuru>> GetById(int id);
        IResult Add(EnumTuru enumTuru);
        IResult Delete(EnumTuru enumTuru);
        IResult Update(EnumTuru enumTuru);

    }
}
