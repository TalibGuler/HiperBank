using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMusteriService
    {
        IDataResult<List<Musteri>> GetAll();
        IDataResult<List<Musteri>> GetById(int id);
        IResult Add(Musteri musteri);
        IResult Delete(Musteri musteri);
        IResult Update(Musteri musteri);
    }
}
