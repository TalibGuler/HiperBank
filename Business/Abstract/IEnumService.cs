using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enum = Core.Entities.Concrete.Enum;

namespace Business.Abstract
{
    public interface IEnumService
    {
        IDataResult<List<Enum>> GetAll();
        IDataResult<List<Enum>> GetById(int id);
        IResult Add(Enum _enum);
        IResult Update(Enum _enum);
        IResult Delete(Enum _enum);
    }
}
