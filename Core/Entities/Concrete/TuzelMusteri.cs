using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class TuzelMusteri : IEntity
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public string Unvan { get; set; }
        public int VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public string Yetkili { get; set; }
    }
}
