﻿using Core.DataAccess;
using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Abstract
{
    public interface IGercekMusteriRepository : IEntityRepository<GercekMusteri>
    {
        //bool DeleteByEntity(GercekMusteri gercekMusteri);
    }
}
