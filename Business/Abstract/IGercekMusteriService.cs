﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGercekMusteriService
    {
        IDataResult<List<GercekMusteri>> GetAll();
        IDataResult<List<GercekMusteri>> GetById(int id);
        IResult Add(GercekMusteri gercekMusteri);
        IResult Delete(GercekMusteri gercekMusteri);
        IResult Update(GercekMusteri gercekMusteri);

    }
}