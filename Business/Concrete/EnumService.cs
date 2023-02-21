using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EnumService : IEnumService
    {
        IEnumRepository _enumRepository;

        public EnumService(IEnumRepository enumRepository)
        {
            _enumRepository = enumRepository;
        }

        public IResult Add(Core.Entities.Concrete.Enum _enum)
        {
            _enumRepository.Add(_enum);
            return new SuccessResult(Messages.Add);
        }

        public IResult Delete(Core.Entities.Concrete.Enum _enum)
        {
            _enumRepository.Delete(_enum);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<List<Core.Entities.Concrete.Enum>> GetAll()
        {
           return new SuccessDataResult<List<Core.Entities.Concrete.Enum>>(_enumRepository.GetAll(),Messages.Listed);
        }

        public IDataResult<List<Core.Entities.Concrete.Enum>> GetById(int id)
        {
            return new SuccessDataResult<List<Core.Entities.Concrete.Enum>>(_enumRepository.GetAll(p=>p.Id==id),Messages.Listed);
        }

        public IResult Update(Core.Entities.Concrete.Enum _enum)
        {
            _enumRepository.Update(_enum);
            return new SuccessResult(Messages.Update);
        }
    }
}
