using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MusteriService : IMusteriService
    {
        IMusteriRepository _musteriRepository;

        public MusteriService(IMusteriRepository musteriRepository)
        {
            _musteriRepository = musteriRepository;
        }

        public IResult Add(Musteri musteri)
        {
            _musteriRepository.Add(musteri);
            return new SuccessResult(Messages.Add);
        }

        public IResult Delete(Musteri musteri)
        {
            _musteriRepository.Delete(musteri);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<IEnumerable<Musteri>> GetAll()
        {
            return new SuccessDataResult<IEnumerable<Musteri>>(_musteriRepository.GetAll(), Messages.Listed);
        }

        public IDataResult<IEnumerable<Musteri>> GetById(int id)
        {
            return new SuccessDataResult<IEnumerable<Musteri>>(_musteriRepository.GetAll(p=> p.Id == id),Messages.Listed);
        }

        public IResult Update(Musteri musteri)
        {
            _musteriRepository.Update(musteri);
            return new SuccessResult(Messages.Update);
        }
    }
}
