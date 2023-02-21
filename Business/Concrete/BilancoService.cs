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
    public class BilancoService : IBilancoService
    {
        IBilancoRepository _bilancoRepository;

        public BilancoService(IBilancoRepository bilancoRepository)
        {
            _bilancoRepository = bilancoRepository;
        }

        public IResult Add(Bilanco bilanco)
        {
            _bilancoRepository.Add(bilanco);
            return new SuccessResult(Messages.Add);
        }

        public IResult Delete(Bilanco bilanco)
        {
            _bilancoRepository.Delete(bilanco);
            return new SuccessResult(Messages.Delete);
        }

        public IDataResult<List<Bilanco>> GetAll()
        {
            return new SuccessDataResult<List<Bilanco>>(_bilancoRepository.GetAll(), Messages.Listed);
        }

        public IDataResult<List<Bilanco>> GetById(int id)
        {
            return new SuccessDataResult<List<Bilanco>>(_bilancoRepository.GetAll(b => b.Id == id), Messages.Listed);
        }

        public IResult Update(Bilanco bilanco)
        {
            _bilancoRepository.Update(bilanco);
            return new SuccessResult(Messages.Update);
        }
    }
}
