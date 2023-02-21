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
    public class MusteriKayitKanaliService : IMusteriKayitKanaliService
    {
        IMusteriKayitKanaliRepository _musteriKayitKanaliRepository;

        public MusteriKayitKanaliService(IMusteriKayitKanaliRepository musteriKayitKanaliRepository)
        {
            _musteriKayitKanaliRepository = musteriKayitKanaliRepository;
        }

        public IResult Add(MusteriKayitKanali musteriKayitKanali)
        {
            _musteriKayitKanaliRepository.Add(musteriKayitKanali);
            return new SuccessResult(Messages.Add);
        }

        public IResult Delete(MusteriKayitKanali musteriKayitKanali)
        {
            _musteriKayitKanaliRepository.Delete(musteriKayitKanali);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<List<MusteriKayitKanali>> GetAll()
        {
            return new SuccessDataResult<List<MusteriKayitKanali>>(_musteriKayitKanaliRepository.GetAll());
        }

        public IDataResult<List<MusteriKayitKanali>> GetById(int id)
        {
            return new SuccessDataResult<List<MusteriKayitKanali>>(_musteriKayitKanaliRepository.GetAll(p => p.Id == id));
        }

     
        public IDataResult<List<MusteriKayitKanaliResponseDto>> GetMusteriKayitKanaliResponseDto()
        {
            return new SuccessDataResult<List<MusteriKayitKanaliResponseDto>>(_musteriKayitKanaliRepository.GetMusteriKayitKanaliResponseDto());

        }

        public IResult Update(MusteriKayitKanali musteriKayitKanali)
        {
            _musteriKayitKanaliRepository.Update(musteriKayitKanali);
            return new SuccessResult(Messages.Update);
        }
    }
}
