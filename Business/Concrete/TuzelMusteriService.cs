using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Repository.Abstract;
using DataAccess.Repository.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TuzelMusteriService : ITuzelMusteriService
    {
        ITuzelMusteriRepository _tuzelMusteriRepository;

        public TuzelMusteriService(ITuzelMusteriRepository tuzelMusteriRepository)
        {
            _tuzelMusteriRepository = tuzelMusteriRepository;
        }

        public IResult Add(TuzelMusteri tuzelMusteri)
        {
            _tuzelMusteriRepository.Add(tuzelMusteri);
            return new SuccessResult(Messages.Add);
        }

        public IResult Delete(TuzelMusteri tuzelMusteri)
        {
            _tuzelMusteriRepository.Delete(tuzelMusteri);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<IEnumerable<TuzelMusteri>> GetAll()
        {
           // return new SuccessDataResult<List<TuzelMusteri>>(_tuzelMusteriRepository.GetAll(), Messages.Listed);
            return new SuccessDataResult<IEnumerable<TuzelMusteri>>(_tuzelMusteriRepository.GetAll(), Messages.Listed);
        }

        public IDataResult<IEnumerable<TuzelMusteri>> GetById(int id)
        {
            return new SuccessDataResult<IEnumerable<TuzelMusteri>>(_tuzelMusteriRepository.GetAll(b => b.Id == id), Messages.Listed);
        }

        public IDataResult<IEnumerable<MusteriBilancoResponseDto>> GetMusteriBilancoResponseDto()
        {
            return new SuccessDataResult<IEnumerable<MusteriBilancoResponseDto>>(_tuzelMusteriRepository.GetMusteriBilancoResponseDto());
        }

        public IResult Update(TuzelMusteri tuzelMusteri)
        {
            _tuzelMusteriRepository.Update(tuzelMusteri);
            return new SuccessResult(Messages.Update);
        }
    }
}
