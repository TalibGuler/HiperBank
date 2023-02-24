using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities.Concrete
{
    public class Musteri : IEntity
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        public bool SilindiMi { get; set; }
    }
}
