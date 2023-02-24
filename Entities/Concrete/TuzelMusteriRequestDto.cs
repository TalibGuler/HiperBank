using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TuzelMusteriRequestDto
    {
        public int Id { get; set; }
        public int MusteriId { get; set; }
        public string Unvan { get; set; }
        public int VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public string Yetkili { get; set; }
        public bool SilindiMi { get; set; }
    }
}
