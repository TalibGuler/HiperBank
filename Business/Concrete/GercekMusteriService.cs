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
    public class GercekMusteriService : IGercekMusteriService
    {
        IGercekMusteriRepository _gercekMusteriRepository;
        public GercekMusteriService(IGercekMusteriRepository gercekMusteriRepository)
        {
            _gercekMusteriRepository = gercekMusteriRepository;
        }

        public IResult Add(GercekMusteri gercekMusteri)
        {
            _gercekMusteriRepository.Add(gercekMusteri);
            return new SuccessResult(Messages.Add);
        }

        public IResult Delete(GercekMusteri gercekMusteri)
        {
            _gercekMusteriRepository.Delete(gercekMusteri);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<IEnumerable<GercekMusteri>> GetAll()
        {
            return new SuccessDataResult<IEnumerable<GercekMusteri>>(_gercekMusteriRepository.GetAll(), Messages.Listed);
        }

        public IDataResult<IEnumerable<GercekMusteri>> GetById(int id)
        {
            return new SuccessDataResult<IEnumerable<GercekMusteri>>(_gercekMusteriRepository.GetAll(p=>p.Id == id), Messages.Listed);
        }

        public IResult Update(GercekMusteri gercekMusteri)
        {
            _gercekMusteriRepository.Update(gercekMusteri);
            return new SuccessResult(Messages.Update);
        }
    }
}
