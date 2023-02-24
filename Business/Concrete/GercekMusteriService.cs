using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using DataAccess.Data;
using DataAccess.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GercekMusteriService : IGercekMusteriService
    {
        IGercekMusteriRepository _gercekMusteriRepository;
        private readonly ProjectDbContext context;
        public GercekMusteriService(IGercekMusteriRepository gercekMusteriRepository, ProjectDbContext context)
        {
            _gercekMusteriRepository = gercekMusteriRepository;
            this.context = context;
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

        public IResult DeleteById(int id)
        {
           var entity = context.GercekMusteri.SingleOrDefault(p=> p.Id == id);

            // Update(entity);
            //_gercekMusteriRepository.DeleteByEntity(entity);

            // var repoResult = entity;
            // context.SaveChanges();
            // return new SuccessResult(Messages.Delete);

            context.GercekMusteri.Remove(entity);
            context.SaveChanges();
            return new SuccessResult(Messages.Delete);
        }

        
    }
}
