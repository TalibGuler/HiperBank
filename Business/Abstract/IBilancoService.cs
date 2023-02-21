using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBilancoService
    {
        IDataResult<IEnumerable<Bilanco>> GetAll();
        IDataResult<IEnumerable<Bilanco>> GetById(int id);
        IResult Add(Bilanco bilanco);
        IResult Update(Bilanco bilanco);
        IResult Delete(Bilanco bilanco);
    }
}
