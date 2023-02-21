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
    public class EnumTuruService : IEnumTuruService
    {
        IEnumTuruRepository _enumTuruRepository;

        public EnumTuruService(IEnumTuruRepository enumTuruRepository)
        {
            _enumTuruRepository= enumTuruRepository;
        }
        
        public IResult Add(EnumTuru enumTuru)
        {
            _enumTuruRepository.Add(enumTuru);
            return new SuccessResult(Messages.Add);
        }

        public IResult Delete(EnumTuru enumTuru)
        {
            _enumTuruRepository.Delete(enumTuru);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<IEnumerable<EnumTuru>> GetById(int id)
        {
            return new SuccessDataResult<IEnumerable<EnumTuru>>(_enumTuruRepository.GetAll(p => p.Id == id),Messages.Listed);
        }

        public IDataResult<IEnumerable<EnumTuru>> GetAll()
        {
            return new SuccessDataResult<IEnumerable<EnumTuru>>(_enumTuruRepository.GetAll(),Messages.Listed);
        }

        public IResult Update(EnumTuru enumTuru)
        {
            _enumTuruRepository.Update(enumTuru);
            return new SuccessResult(Messages.Update);
        }
    }
}
